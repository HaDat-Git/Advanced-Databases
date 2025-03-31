Create database general_clinic_manage;

Use general_clinic_manage;

-- Bảng lưu thông tin người dùng
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female')),
    UserName NVARCHAR(50) UNIQUE NOT NULL,
    PassWord NVARCHAR(255) NOT NULL,  -- Mật khẩu cần mã hóa khi lưu
    Role NVARCHAR(20) CHECK (Role IN ('Admin', 'Doctor')) NOT NULL
);

-- Bảng chi tiết bác sĩ
CREATE TABLE DoctorDetails (
    DoctorID INT PRIMARY KEY,  -- Trùng với UserID trong bảng Users
    Title NVARCHAR(100) NOT NULL,  -- Trình độ (VD: Giáo sư, Phó giáo sư)
    ManagementPosition NVARCHAR(255) NULL,  -- Vị trí quản lý
    Specialties NVARCHAR(100) NOT NULL,  -- Chuyên khoa
    ExperienceYears INT NOT NULL,  -- Số năm kinh nghiệm
    ProfileImage NVARCHAR(255) NULL,  -- Đường dẫn ảnh đại diện
    CONSTRAINT FK_DoctorDetails_User FOREIGN KEY (DoctorID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- Bảng bệnh nhân
CREATE TABLE Patients (
    PatientID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Phone NVARCHAR(20) UNIQUE NOT NULL,
    Email NVARCHAR(100) UNIQUE NULL,
    DOB DATE NULL,
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female')),
    Address NVARCHAR(255) NULL
);

-- Bảng lịch hẹn khám bệnh
CREATE TABLE Appointments (
    AppointmentID INT IDENTITY(1,1) PRIMARY KEY,
    PatientID INT NOT NULL,
    DoctorID INT NOT NULL,  -- Bác sĩ sẽ khám
    About NVARCHAR(255) NOT NULL,  -- Lý do khám
    Description NVARCHAR(MAX) NULL,  -- Mô tả triệu chứng
    AppointmentDate DATETIME DEFAULT GETDATE(),  -- Ngày hẹn khám
    Status NVARCHAR(50) CHECK (Status IN ('Pending', 'Completed', 'Cancelled')) DEFAULT 'Pending',
    CONSTRAINT FK_Appointments_Patient FOREIGN KEY (PatientID) REFERENCES Patients(PatientID) ON DELETE CASCADE,
    CONSTRAINT FK_Appointments_Doctor FOREIGN KEY (DoctorID) REFERENCES Users(UserID) ON DELETE CASCADE
);


-- Bảng lịch làm việc của bác sĩ
CREATE TABLE DoctorSchedules (
    ScheduleID INT IDENTITY(1,1) PRIMARY KEY,
    DoctorID INT NOT NULL,
    WeekDay TINYINT NOT NULL CHECK (WeekDay BETWEEN 1 AND 7),
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    CONSTRAINT FK_DoctorSchedules_Doctor FOREIGN KEY (DoctorID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- Bảng dịch vụ y tế (chuẩn hóa giá trị thành tiền)
CREATE TABLE MedicalServices (
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,
    ServiceName NVARCHAR(255) NOT NULL,
    Price DECIMAL(18,2) NOT NULL
);

-- Bảng hồ sơ khám bệnh
CREATE TABLE MedicalRecords (
    RecordID INT IDENTITY(1,1) PRIMARY KEY,
    AppointmentID INT NOT NULL,  -- Liên kết phiếu khám
    Diagnosis NVARCHAR(MAX) NULL,  -- Chẩn đoán bệnh
    Treatment NVARCHAR(MAX) NULL,  -- Hướng điều trị
    StatusPayment NVARCHAR(50) CHECK (StatusPayment IN ('Pending', 'Paid', 'Cancelled')) DEFAULT 'Pending',
    CONSTRAINT FK_MedicalRecords_Appointment FOREIGN KEY (AppointmentID) REFERENCES Appointments(AppointmentID) ON DELETE CASCADE
);

-- Bảng chi tiết dịch vụ trong hồ sơ khám bệnh
CREATE TABLE MedicalRecordServices (
    RecordID INT NOT NULL,
    ServiceID INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    PRIMARY KEY (RecordID, ServiceID),
    CONSTRAINT FK_MedicalRecordServices_Record FOREIGN KEY (RecordID) REFERENCES MedicalRecords(RecordID) ON DELETE CASCADE,
    CONSTRAINT FK_MedicalRecordServices_Service FOREIGN KEY (ServiceID) REFERENCES MedicalServices(ServiceID) ON DELETE CASCADE
);

-- Bảng kết quả khám bệnh
CREATE TABLE MedicalResults (
    ResultID INT IDENTITY(1,1) PRIMARY KEY,
    RecordID INT NOT NULL,  -- Liên kết hồ sơ khám bệnh
    PrescribedMedicine NVARCHAR(MAX),  -- Thuốc đề xuất
    PDFFileLink NVARCHAR(255) NOT NULL, -- Link file PDF kết quả
    UploadedAt DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_MedicalResults_Record FOREIGN KEY (RecordID) REFERENCES MedicalRecords(RecordID) ON DELETE CASCADE
);


-- Thêm danh sách bác sĩ vào Users
INSERT INTO Users (FullName, Gender, UserName, PassWord, Role)
VALUES 
    (N'PGS.TS Trịnh Thị Ngọc', N'Female', 'dr.trinhngoc', 'trinhngoc123', 'Doctor'),
    (N'PGS.TS Nguyễn Thị Vân Hồng', N'Female', 'dr.nguyenvanhong', 'nguyenvanhong123', 'Doctor'),
    (N'TTƯT.PGS.TS.BS Vũ Quang Huy', N'Female', 'dr.vuhuy', 'vuhuy123', 'Doctor'),
    (N'PGS.TS.BSCC Nguyễn Mai Hồng', N'Female', 'dr.nguyenmaihong', 'nguyenmaihong123', 'Doctor'),
    (N'TTND.TTƯT.PGS.TS Phạm Thị Hồng Thi', N'Male', 'dr.phamthi', 'phamthi123', 'Doctor'),
    (N'PGS.TS.BSCC Lê Chính Đại', N'Male', 'dr.ledai', 'ledai123', 'Doctor');

-- Thêm thông tin chi tiết vào DoctorDetails
INSERT INTO DoctorDetails (DoctorID, Title, ManagementPosition, Specialties, ExperienceYears, ProfileImage)
SELECT 
    UserID,
    N'Phó giáo sư',
    CASE 
        WHEN FullName = N'PGS.TS Trịnh Thị Ngọc' THEN N'Nguyên Trưởng khoa Truyền nhiễm, Bệnh viện Bạch Mai'
        WHEN FullName = N'PGS.TS Nguyễn Thị Vân Hồng' THEN N'Nguyên Phó trưởng khoa Tiêu hóa, Bệnh viện Bạch Mai'
        WHEN FullName = N'TTƯT.PGS.TS.BS Vũ Quang Huy' THEN N'Giám đốc Trung tâm kiểm chuẩn chất lượng xét nghiệm y học - Bộ Y tế'
        WHEN FullName = N'PGS.TS.BSCC Nguyễn Mai Hồng' THEN N'Chuyên gia, Bác sĩ điều trị, Khoa Cơ xương khớp Bệnh viện Bạch Mai.'
        WHEN FullName = N'TTND.TTƯT.PGS.TS Phạm Thị Hồng Thi' THEN N'Nguyên Phó Viện trưởng Viện Tim mạch, Bệnh viện Bạch Mai'
        WHEN FullName = N'PGS.TS.BSCC Lê Chính Đại' THEN N'Nguyên Phó Giám đốc Trung tâm Y học hạt nhân và ung bướu, Bệnh viện Bạch Mai'
    END,
    CASE 
        WHEN FullName = N'PGS.TS Trịnh Thị Ngọc' THEN N'Truyền nhiễm'
        WHEN FullName = N'PGS.TS Nguyễn Thị Vân Hồng' THEN N'Tiêu hóa'
        WHEN FullName = N'TTƯT.PGS.TS.BS Vũ Quang Huy' THEN N'Xét nghiệm'
        WHEN FullName = N'PGS.TS.BSCC Nguyễn Mai Hồng' THEN N'Cơ xương khớp'
        WHEN FullName = N'TTND.TTƯT.PGS.TS Phạm Thị Hồng Thi' THEN N'Tim mạch'
        WHEN FullName = N'PGS.TS.BSCC Lê Chính Đại' THEN N'Ung bướu'
    END,
    40,
    NULL
FROM Users WHERE Role = 'Doctor';

-- Thêm tài khoản Admin
INSERT INTO Users (FullName, Gender, UserName, PassWord, Role)
VALUES (N'Admin System', N'Male', 'admin', 'admin123', N'Admin');

-- Thêm bệnh nhân
INSERT INTO Patients (FullName, Phone, Email, DOB, Gender, Address)
VALUES (N'Trần Thị B', '0987654321', 'tranb@gmail.com', '1990-05-12', 'Female', N'Hà Nội');

-- Thêm phiếu khám
INSERT INTO Appointments (PatientID, DoctorID, About, Description)
VALUES (1, 2, N'Khám tim mạch', N'Đau tức ngực, khó thở');

-- Thêm hồ sơ khám bệnh
INSERT INTO MedicalRecords (AppointmentID, Diagnosis, Treatment, StatusPayment)
VALUES (1, N'Bệnh tim nhẹ', N'Uống thuốc mỗi ngày', 'Pending');

-- Thêm dịch vụ y tế
INSERT INTO MedicalServices (ServiceName, Price)
VALUES (N'Khám tim mạch', 500000);

-- Liên kết dịch vụ với hồ sơ khám bệnh
INSERT INTO MedicalRecordServices (RecordID, ServiceID, Quantity)
VALUES (1, 1, 1);

-- Thêm kết quả khám bệnh
INSERT INTO MedicalResults (RecordID, PrescribedMedicine, PDFFileLink)
VALUES (1, N'Thuốc tim mạch A', 'tranb.pdf');


ALTER TABLE DoctorDetails DROP CONSTRAINT IF EXISTS FK_DoctorDetails_User;
ALTER TABLE Appointments DROP CONSTRAINT IF EXISTS FK_Appointments_Patient;
ALTER TABLE Appointments DROP CONSTRAINT IF EXISTS FK_Appointments_Doctor;
ALTER TABLE DoctorSchedules DROP CONSTRAINT IF EXISTS FK_DoctorSchedules_Doctor;
ALTER TABLE MedicalRecords DROP CONSTRAINT IF EXISTS FK_MedicalRecords_Appointment;
ALTER TABLE MedicalRecordServices DROP CONSTRAINT IF EXISTS FK_MedicalRecordServices_Record;
ALTER TABLE MedicalRecordServices DROP CONSTRAINT IF EXISTS FK_MedicalRecordServices_Service;
ALTER TABLE MedicalResults DROP CONSTRAINT IF EXISTS FK_MedicalResults_Record;


DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS DoctorDetails;
DROP TABLE IF EXISTS Patients;
DROP TABLE IF EXISTS Appointments;
DROP TABLE IF EXISTS DoctorSchedules;
DROP TABLE IF EXISTS MedicalRecords;
DROP TABLE IF EXISTS MedicalResults;
DROP TABLE IF EXISTS MedicalServices;
DROP TABLE IF EXISTS MedicalRecordServices;


SELECT * FROM Users;
SELECT * FROM DoctorDetails;
SELECT * FROM Patients;
SELECT * FROM Appointments;
SELECT * FROM DoctorSchedules;
SELECT * FROM MedicalServices;
SELECT * FROM MedicalRecords;
SELECT * FROM MedicalRecordServices;
SELECT * FROM MedicalResults;


