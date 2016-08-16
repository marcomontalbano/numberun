/*
*
*	- nome:   USERS_PWD	
*	- azione: crea tabella
*	- autore: Marco Montalbano
*	
*	- descrizione:
*	Crea una tabella 'users_pwd', dove vengono conservate
*	alcune informazioni dell'utente registrato.
*	Il nome dell'utente (codice univoco), la sua password e
*	il privilegio che possiede all'interno del gioco:
*	   ^ admin:	amministratore del gioco.
*	   ^ user:	semplice utente con capacità limitate
*			all'interno del gioco.
*	   ^ ispettore:	controlla che ke regole vengano rispettate.
*	   ^ newswr:	è addetto all'invio dei messaggi di news.
*	Questi privilegi all'interno del gioco non hanno potere
*	(escluso il caso degli 'ispettori'), mentre hanno potere
*	nel tool d'amministrazione del gioco.
*	
*/

-- crea la tabella userpwd
CREATE TABLE users_pwd
(
	users           char(25),           -- nome dell'utente
	passwords       char(15),	     	-- password dell'utente
	privilegio      char(15),	     	-- privilegio dell'utente
	n_reg           serial,             -- indica il numero della registrazione
	enabled			boolean,            -- è true se l'account è abilitato
	data			char(10),           -- è la data in cui ha effettuato la registrazione (gg/mm/yyyy)
	ora				char(8),            -- è l'ora in cui ha effettuato la registrazione (hh.mm.ss)
	reg_key         char(20),           -- è il codice per la registrazione
	CONSTRAINT userpwd_pkey_users PRIMARY KEY (users)       -- mantieni ordinato l'indice
);

-- indicizza l'indice id
CREATE INDEX userpwd_i_users
   ON users_pwd (users);