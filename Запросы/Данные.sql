-- Вставка данных в таблицу UserTypes
INSERT INTO UserTypes (typeDescription) VALUES 
('Менеджер'),
('Мастер'),
('Оператор'),
('Заказчик');

-- Вставка данных в таблицу Users
INSERT INTO Users (fio, phone, login, password, userTypeID) VALUES 
('Носов Иван Михайлович', '89210563128', 'login1', 'pass1', 1),
('Ильин Александр Андреевич', '89535078985', 'login2', 'pass2', 2),
('Никифоров Иван Дмитриевич', '89210673849', 'login3', 'pass3', 2),
('Елисеев Артём Леонидович', '89990563748', 'login4', 'pass4', 3),
('Титов Сергей Кириллович', '89994563847', 'login5', 'pass5', 3),
('Григорьев Семён Викторович', '89219567849', 'login11', 'pass11', 4),
('Сорокин Дмитрий Ильич', '89219567841', 'login12', 'pass12', 4),
('Белоусов Егор Ярославович', '89219567842', 'login13', 'pass13', 4),
('Суслов Михаил Александрович', '89219567843', 'login14', 'pass14', 4),
('Васильев Вячеслав Александрович', '89219567844', 'login15', 'pass15', 2);

-- Вставка данных в таблицу RequestStatus
INSERT INTO RequestStatus (statusDescription) VALUES 
('В процессе ремонта'),
('Готова к выдаче'),
('Новая заявка');

-- Вставка данных в таблицу OrgTech
INSERT INTO OrgTech (orgTechType, orgTechModel) VALUES 
('Компьютер', 'DEXP Aquilon O286'),
('Компьютер', 'DEXP Atlas H388'),
('Ноутбук', 'MSI GF76 Katana 11UC-879XRU черный'),
('Ноутбук', 'MSI Modern 15 B12M-211RU черный'),
('Принтер', 'HP LaserJet Pro M404dn');

-- Вставка данных в таблицу Requests
INSERT INTO Requests (startDate, problemDescription, requestStatusID, completionDate, repairParts, masterID, clientID) VALUES 
('2023-06-06', 'Перестал работать', 1, NULL, NULL, 2, 7),
('2023-05-05', 'Перестал работать', 1, NULL, NULL, 3, 8),
('2022-07-07', 'Выключается', 2, '2023-01-01', NULL, 3, 9),
('2023-08-02', 'Выключается', 3, NULL, NULL, NULL, 8),
('2023-08-02', 'Перестала включаться', 3, NULL, NULL, NULL, 9);

-- Вставка данных в таблицу RequestTech
INSERT INTO RequestTech (requestID, orgTechID) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

-- Вставка данных в таблицу Comments
INSERT INTO Comments (message, masterID, requestID) VALUES 
('Интересно...', 2, 1),
('Будем разбираться!', 3, 2),
('Сделаем всё на высшем уровне!', 3, 3);
