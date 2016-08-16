/*
*
*	- nome:   USERS_LOGIN
*	- azione: crea tabella
*	- autore: RPGames
*	
*	- descrizione:
*	Crea una tabella 'users_login', dove vengono conservate
*	alcune informazioni dell'utente registrato.
*	Il nome dell'utente (codice univoco).
*	
*/

-- crea la tabella userpwd
CREATE TABLE users_login
(
	users           char(25),            -- nome dell'utente
	
	login_user	boolean,             -- se 'true' l'utente è collegato
	reset_user	boolean,             -- se 'true' = F5 reset del gioco
	ultimo_accesso_data  char(10),            -- data del giorno dell'ultimo accesso
	ultimo_accesso_ora   char(8),            -- ora del giorno dell'ultimo accesso
	ip  		char(15),            -- ip della macchina nell'ultimo accesso

	CONSTRAINT users_login_pkey_users PRIMARY KEY (users)       -- mantieni ordinato l'indice
);

-- indicizza l'indice id
CREATE INDEX users_login_i_users
   ON users_login (users);