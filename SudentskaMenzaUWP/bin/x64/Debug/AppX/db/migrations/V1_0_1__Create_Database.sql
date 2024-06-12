CREATE TABLE STUDENT(
	id INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
	xica VARCHAR(11) NOT NULL,
	puno_ime VARCHAR(128) NOT NULL,
	lozinka_hash varchar(72) NOT NULL,
);

CREATE TABLE JELO(
	id INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
	naziv VARCHAR(32),
);

CREATE TABLE MENI(
	id INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
	naziv VARCHAR(32),
);

CREATE TABLE MENI_JELO(
	jelo_id INTEGER NOT NULL FOREIGN KEY references JELO(id),
	meni_id INTEGER NOT NULL FOREIGN KEY references MENI(id),
	CONSTRAINT pk_meni_jelo PRIMARY KEY (jelo_id, meni_id),
);

CREATE TABLE MENI_DAN(
	meni_id INTEGER NOT NULL FOREIGN KEY references MENI(id),
	dan VARCHAR(10) NOT NULL,
	CONSTRAINT pk_meni_dan PRIMARY KEY (meni_id, dan),
	CONSTRAINT cv_dan CHECK (dan in ('PONEDJELJAK', 'UTORAK', 'SRIJEDA', 'CETVRTAK', 'PETAK', 'SUBOTA', 'NEDJELJA')),
);

CREATE TABLE NARUDZBA(
	id INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
	meni_id INTEGER NOT NULL FOREIGN KEY references MENI(id),
	student_id INTEGER NOT NULL FOREIGN KEY references STUDENT(id),
	ocjena_okus INTEGER,
	ocjena_kolicina INTEGER,
	komentar varchar (256),
	vrijeme_izdavanja DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	tip varchar(32) NOT NULL,
	CONSTRAINT cv_tip CHECK (tip in ('APLIKACIJA', 'UZIVO')),
);

CREATE TABLE NARUDZBA_STATUS(
	id INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
	narudzba_id INTEGER NOT NULL FOREIGN KEY references NARUDZBA(id),
	status varchar(32) NOT NULL,
	vrijeme_zadavanja DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	CONSTRAINT cv_status CHECK (status in ('ZADANO', 'U_OBRADI', 'SPREMNO', 'POSLUZENO')),
);

CREATE TABLE VODITELJ_MENZE(
	id INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
	korisnicko_ime VARCHAR(128) NOT NULL,
	puno_ime VARCHAR(128) NOT NULL,
	lozinka_hash varchar(72) NOT NULL,
);