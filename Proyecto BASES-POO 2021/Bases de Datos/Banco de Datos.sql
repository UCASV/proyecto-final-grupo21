
CREATE DATABASE VacunacionDB;	
USE VacunacionDB; 				
SET LANGUAGE us_english;
DROP DATABASE VacunacionDB;

-- Tables section.
CREATE TABLE GESTOR (
	id INT PRIMARY KEY IDENTITY NOT NULL,
	username VARCHAR(50) UNIQUE NOT NULL,
	pass VARCHAR(50) NOT NULL,
);

CREATE TABLE REGISTER (
	id INT PRIMARY KEY IDENTITY NOT NULL,
	id_gestor INT NOT NULL,
	gestor VARCHAR(50) NOT NULL,
	login_day VARCHAR(50) NOT NULL,
	login_time VARCHAR(50) NOT NULL,
);


CREATE TABLE GESTORXCABIN (
	id INT PRIMARY KEY IDENTITY NOT NULL,
	id_gestor INT NOT NULL,
	id_cabin INT NOT NULL
);


CREATE TABLE CABIN (
	id INT PRIMARY KEY IDENTITY NOT NULL,
	email VARCHAR(50) UNIQUE NOT NULL,
	phone INT UNIQUE NOT NULL,
	adress VARCHAR(50) NOT NULL
);

CREATE TABLE EMPLOYEE (
	id INT PRIMARY KEY IDENTITY NOT NULL,
	id_cabin INT NOT NULL,
	employee_name VARCHAR(50) NOT NULL,
	adress VARCHAR(50) UNIQUE NOT NULL,
	email VARCHAR(50) UNIQUE NOT NULL,
	id_type_employee INT NOT NULL
);

CREATE TABLE TYPE_EMPLOYEE (
	id INT PRIMARY KEY IDENTITY NOT NULL,
	type_employee VARCHAR(50) NOT NULL
);

CREATE TABLE CITIZEN (
	id INT PRIMARY KEY IDENTITY NOT NULL,
	id_gestor INT NOT NULL,
	id_institution INT NOT NULL,
	age INT NOT NULL,
	email VARCHAR(50) UNIQUE NOT NULL,
	DUI VARCHAR(50) UNIQUE NOT NULL,
	phone INT UNIQUE NOT NULL,
	adress VARCHAR(50) UNIQUE NOT NULL,
	full_name VARCHAR(50) NOT NULL
);

CREATE TABLE SICKNESS (
	id INT PRIMARY KEY IDENTITY NOT NULL,
	id_citizen INT NOT NULL,
	sickness VARCHAR(50) NOT NULL,
);


CREATE TABLE INSTITUTION (
	id INT PRIMARY KEY IDENTITY NOT NULL,
	institution VARCHAR(30)
);


CREATE TABLE CONSULT (
	id INT PRIMARY KEY NOT NULL,
	consultation_day VARCHAR(30) NOT NULL,
	consultation_time VARCHAR(30) NOT NULL,
	id_cabin INT NOT NULL,
	id_citizen INT NOT NULL
);


CREATE TABLE VACCINATION_PROCESS (
	id INT PRIMARY KEY NOT NULL,
	vaccunation_day VARCHAR(50) NOT NULL,
	vaccunation_time VARCHAR(50) NOT NULL,
	current_step VARCHAR(20) NOT NULL,
	second_vaccination_day VARCHAR(50) NOT NULL,
	second_vaccination_time VARCHAR(50) NOT NULL,
	vaccunation_place VARCHAR(50) NOT NULL,
	id_consult INT NOT NULL
);

CREATE TABLE SECONDARY_EFFECTS (
	id INT PRIMARY KEY NOT NULL,
	id_vaccination_process INT NOT NULL,
	seccondary_effects VARCHAR(50) NOT NULL
);

-- Foreign Key section.
-- GESTOR -> GESTOR
ALTER TABLE REGISTER ADD FOREIGN KEY (id_gestor) REFERENCES GESTOR(id);
-- EMPLOYEE -> TYPE_EMPLOYEE
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (id_type_employee) REFERENCES TYPE_EMPLOYEE(id);
-- EMPLOYEE -> CABIN
ALTER TABLE EMPLOYEE ADD FOREIGN KEY (id_cabin) REFERENCES CABIN(id);
-- CITIZEN -> INSTITUTION
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_institution) REFERENCES INSTITUTION(id);
-- CITIZEN -> GESTOR
ALTER TABLE CITIZEN ADD FOREIGN KEY (id_gestor) REFERENCES GESTOR(id);
-- SICKNESS -> CITYZEN
ALTER TABLE SICKNESS ADD FOREIGN KEY (id_citizen) REFERENCES CITIZEN(id);
-- CONSULT -> CABIN
ALTER TABLE CONSULT ADD FOREIGN KEY (id_cabin) REFERENCES CABIN(id);
-- CONSULT -> CITYZEN
ALTER TABLE CONSULT ADD FOREIGN KEY (id_citizen) REFERENCES CITIZEN(id);
-- VACCINATION_PROCESS -> CONSULT
ALTER TABLE VACCINATION_PROCESS ADD FOREIGN KEY (id_consult) REFERENCES CONSULT(id);
-- SECONDARY_EFFECTS -> VACCINATION_PROCESS
ALTER TABLE SECONDARY_EFFECTS ADD FOREIGN KEY (id_vaccination_process) REFERENCES VACCINATION_PROCESS(id);

-- GESTORXCABIN -> GESTOR, CABIN
ALTER TABLE GESTORXCABIN ADD CONSTRAINT fk_gestor_gestorxcabin FOREIGN KEY(id_gestor) REFERENCES GESTOR(id)
ALTER TABLE GESTORXCABIN ADD CONSTRAINT fk_cabin_gestorxcabin FOREIGN KEY(id_cabin) REFERENCES CABIN(id)

--Data Section
--inserting values in CABIN table
INSERT INTO CABIN VALUES ('FirstCabin_covid@gmail.com',22740085,'3era. Calle Poniente Norte, Plaza Barrios');
INSERT INTO CABIN VALUES ('SecondCabin_covid@gmail.com',21015566,'75ave. Sur, Mejicanos, San Salvador');
INSERT INTO CABIN VALUES ('FirstSpecialCabin_covid@gmail.com',22020099,'Col. Miramonte, Santa Tecla, San Salvador');
INSERT INTO CABIN VALUES ('ThirdCabin_covid@gmail.com',25553102,'Plaza México, Santa Ana');
INSERT INTO CABIN VALUES ('FourthCabin_covid@gmail.com',78936556,'Calle Manzaneros, Sonsonate');
INSERT INTO CABIN VALUES ('SecondSpecialCabin_covid@gmail.com',22569636,'Col. Rosales, La Palma, Chalatenango');

--inserting values in TYPE_EMPLOYEE table
INSERT INTO TYPE_EMPLOYEE VALUES ('asistente enfermero/a');
INSERT INTO TYPE_EMPLOYEE VALUES ('encargado/a de software y hardware');
INSERT INTO TYPE_EMPLOYEE VALUES ('digitador/a');
INSERT INTO TYPE_EMPLOYEE VALUES ('doctor/a');

--inserting values in EMPLOYEE table
INSERT INTO EMPLOYEE VALUES (1,'Sergio Argueta', 'Col. Santa María, Mejicanos', 'asfjasfudfkjs@gmail.com', 3);
INSERT INTO EMPLOYEE VALUES (1,'Amanda Huezo', 'Residencial Luces de Santa Ana', '684865vddfvd@gmail.com', 1);
INSERT INTO EMPLOYEE VALUES (1,'Lili Montes', 'Urbanización la Gloria, Mejicanos', 'vsvssvsfg6@gmail.com', 4);
INSERT INTO EMPLOYEE VALUES (2,'Patricia Benavides', 'Col. Mercedez, Zaragoza', 'sdvsv6464@gmail.com', 1);
INSERT INTO EMPLOYEE VALUES (2,'Mario López', 'Calle San Miguel, Lote #34, San Miguel', 'jgng3211cvdfb654@gmail.com', 2);
INSERT INTO EMPLOYEE VALUES (2,'Enrique Perez', 'Col. Asunción, Lourdes', 'aasdwegfgnhluihgb@gmail.com', 4);
INSERT INTO EMPLOYEE VALUES (3,'Manuel Rodríguez', 'Col. Milagro, Pasaje #3, Bloque A, #4', 'dfhfhfgbf8@gmail.com', 3);
INSERT INTO EMPLOYEE VALUES (3,'Mónica Iraheta', 'Residencial Las Flores, La Libertad', 'wwdfsgdfg98@gmail.com', 4);
INSERT INTO EMPLOYEE VALUES (4,'Lucas Salinas', 'Urbanización Villa Alta, Sonsonate', 'bfdghihl654@gmail.com', 1);
INSERT INTO EMPLOYEE VALUES (4,'Natanael Pineda', 'Col. Las Perlas, Casa #5, Ahuachapán', 'asdf66548112@gmail.com', 2);
INSERT INTO EMPLOYEE VALUES (5,'Sara Alegría', 'Residencial Miranda, San Salvador', 'llksdfbsdnn@gmail.com', 4);
INSERT INTO EMPLOYEE VALUES (5,'Daniela Zuñiga', 'Cantón Masferrer, Mejicanos', 'hyvilsdb8@gmail.com', 3);
INSERT INTO EMPLOYEE VALUES (6,'Vilma Quezada', 'Col. Tarsis, Sonsonate', 'aslhfaslhidf@gmail.com', 4);

--inserting values in GESTOR table
INSERT INTO GESTOR VALUES ('MichaelServer','Michael20062000');
INSERT INTO GESTOR VALUES ('FelipeServer','Felipe15031998');

--inserting values in INSTITUTION table
INSERT INTO INSTITUTION VALUES ('Ministerio de Educación');
INSERT INTO INSTITUTION VALUES ('Ministerio de Salud');
INSERT INTO INSTITUTION VALUES ('Ministerio de Economía');
INSERT INTO INSTITUTION VALUES ('Policía Nacional Civil');
INSERT INTO INSTITUTION VALUES ('Fuerza Armada');
INSERT INTO INSTITUTION VALUES ('Ministerio de Gobierno');
INSERT INTO INSTITUTION VALUES ('Asociación de Periodistas');
INSERT INTO INSTITUTION VALUES ('Ministerio de Turismo');

--inserting values in GESTORXCABIN
INSERT INTO GESTORXCABIN VALUES (2,2);
INSERT INTO GESTORXCABIN VALUES (1,6);
INSERT INTO GESTORXCABIN VALUES (2,1);
INSERT INTO GESTORXCABIN VALUES (2,3);
INSERT INTO GESTORXCABIN VALUES (1,5);
INSERT INTO GESTORXCABIN VALUES (1,4);

--view data
SELECT * FROM GESTOR;
SELECT * FROM GESTORXCABIN;
SELECT * FROM TYPE_EMPLOYEE;
SELECT * FROM EMPLOYEE;
SELECT * FROM CABIN;
SELECT * FROM INSTITUTION;