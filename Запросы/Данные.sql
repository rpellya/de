-- ������� ������ � ������� UserTypes
INSERT INTO UserTypes (typeDescription) VALUES 
('��������'),
('������'),
('��������'),
('��������');

-- ������� ������ � ������� Users
INSERT INTO Users (fio, phone, login, password, userTypeID) VALUES 
('����� ���� ����������', '89210563128', 'login1', 'pass1', 1),
('����� ��������� ���������', '89535078985', 'login2', 'pass2', 2),
('��������� ���� ����������', '89210673849', 'login3', 'pass3', 2),
('������� ���� ����������', '89990563748', 'login4', 'pass4', 3),
('����� ������ ����������', '89994563847', 'login5', 'pass5', 3),
('��������� ���� ����������', '89219567849', 'login11', 'pass11', 4),
('������� ������� �����', '89219567841', 'login12', 'pass12', 4),
('�������� ���� �����������', '89219567842', 'login13', 'pass13', 4),
('������ ������ �������������', '89219567843', 'login14', 'pass14', 4),
('�������� �������� �������������', '89219567844', 'login15', 'pass15', 2);

-- ������� ������ � ������� RequestStatus
INSERT INTO RequestStatus (statusDescription) VALUES 
('� �������� �������'),
('������ � ������'),
('����� ������');

-- ������� ������ � ������� OrgTech
INSERT INTO OrgTech (orgTechType, orgTechModel) VALUES 
('���������', 'DEXP Aquilon O286'),
('���������', 'DEXP Atlas H388'),
('�������', 'MSI GF76 Katana 11UC-879XRU ������'),
('�������', 'MSI Modern 15 B12M-211RU ������'),
('�������', 'HP LaserJet Pro M404dn');

-- ������� ������ � ������� Requests
INSERT INTO Requests (startDate, problemDescription, requestStatusID, completionDate, repairParts, masterID, clientID) VALUES 
('2023-06-06', '�������� ��������', 1, NULL, NULL, 2, 7),
('2023-05-05', '�������� ��������', 1, NULL, NULL, 3, 8),
('2022-07-07', '�����������', 2, '2023-01-01', NULL, 3, 9),
('2023-08-02', '�����������', 3, NULL, NULL, NULL, 8),
('2023-08-02', '��������� ����������', 3, NULL, NULL, NULL, 9);

-- ������� ������ � ������� RequestTech
INSERT INTO RequestTech (requestID, orgTechID) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

-- ������� ������ � ������� Comments
INSERT INTO Comments (message, masterID, requestID) VALUES 
('���������...', 2, 1),
('����� �����������!', 3, 2),
('������� �� �� ������ ������!', 3, 3);
