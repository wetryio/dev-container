
CREATE DATABASE `tododb`;
CREATE USER 'todoapplication' IDENTIFIED BY '!todoapplication';
GRANT ALL privileges ON tododb.* TO 'todoapplication'@'%';
FLUSH PRIVILEGES;