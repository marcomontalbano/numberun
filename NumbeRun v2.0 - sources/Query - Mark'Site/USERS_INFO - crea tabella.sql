/*
*
*	- nome:   USERS_INFO
*	- azione: crea tabella
*	- autore: RPGames
*	
*	- descrizione:
*	Crea una tabella 'users_info', dove vengono conservate
*	alcune informazioni dell'utente registrato:
*	sono le informazioni che l'utente inserisce nella registrazione.
*	Il nome dell'utente (codice univoco).
*	
*/

-- crea la tabella users_info
CREATE TABLE users_info
(
	users           char(25),            -- nome dell'utente
	
	email		char(50),            -- e-mail dell'utente
	borndate	char(10),            -- è la data di nascita (gg/mm/yyyy)
	nome		char(25),            -- nome dell'utente registrato
	cognome		char(25),            -- cognome dell'utente registrato
	nazionalita	char(40),            -- nazionalità dell'utente
	sesso		char(1),             -- sesso: m->maschio; f->femmina
	news_enable	boolean,             -- se 'si' attiva servizio news, altrimenti 'no'
	lingua_game	char(20),            -- imposta la lingua utilizzata nel gioco
	
	CONSTRAINT users_info_pkey_users PRIMARY KEY (users)       -- mantieni ordinato l'indice
	
);

-- indicizza l'indice id
CREATE INDEX users_info_i_users
   ON users_info (users);