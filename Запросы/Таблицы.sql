-- ������� ��� �������� ����� �������������
CREATE TABLE UserTypes (
    userTypeID INT PRIMARY KEY IDENTITY(1,1),
    typeDescription NVARCHAR(50) NOT NULL
);

-- ������� ��� �������� �������������
CREATE TABLE Users (
    userID INT PRIMARY KEY IDENTITY(1,1),
    fio NVARCHAR(100) NOT NULL,
    phone NVARCHAR(15) NOT NULL,
    login NVARCHAR(50) NOT NULL,
    password NVARCHAR(50) NOT NULL,
    userTypeID INT NOT NULL,
    FOREIGN KEY (userTypeID) REFERENCES UserTypes(userTypeID)
);

-- ������� ��� �������� �������� ������
CREATE TABLE RequestStatus (
    requestStatusID INT PRIMARY KEY IDENTITY(1,1),
    statusDescription NVARCHAR(50) NOT NULL
);

-- ������� ��� �������� ����� � ������� ����������
CREATE TABLE OrgTech (
    orgTechID INT PRIMARY KEY IDENTITY(1,1),
    orgTechType NVARCHAR(50) NOT NULL,
    orgTechModel NVARCHAR(100) NOT NULL
);

-- ������� ��� �������� ������
CREATE TABLE Requests (
    requestID INT PRIMARY KEY IDENTITY(1,1),
    startDate DATE NOT NULL,
    problemDescription NVARCHAR(255) NOT NULL,
    requestStatusID INT NOT NULL,
    completionDate DATE NULL,
    repairParts NVARCHAR(255) NULL,
    masterID INT NULL,
    clientID INT NOT NULL,
    FOREIGN KEY (requestStatusID) REFERENCES RequestStatus(requestStatusID),
    FOREIGN KEY (masterID) REFERENCES Users(userID),
    FOREIGN KEY (clientID) REFERENCES Users(userID)
);

-- ������� ��� ����� ������ � ����������
CREATE TABLE RequestTech (
    requestID INT NOT NULL,
    orgTechID INT NOT NULL,
    PRIMARY KEY (requestID, orgTechID),
    FOREIGN KEY (requestID) REFERENCES Requests(requestID),
    FOREIGN KEY (orgTechID) REFERENCES OrgTech(orgTechID)
);

-- ������� ��� �������� ������������
CREATE TABLE Comments (
    commentID INT PRIMARY KEY IDENTITY(1,1),
    message NVARCHAR(255) NOT NULL,
    masterID INT NOT NULL,
    requestID INT NOT NULL,
    FOREIGN KEY (masterID) REFERENCES Users(userID),
    FOREIGN KEY (requestID) REFERENCES Requests(requestID)
);
