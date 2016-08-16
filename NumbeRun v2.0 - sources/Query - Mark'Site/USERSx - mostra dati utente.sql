/*
*
*	- nome:   USERSx	
*	- azione: mostra dati utente
*	- autore: RPGames
*	
*	- descrizione:
*	mostra tutti i dati di tutte le tabelle, riguardanti l'utente selezionato
*	
*/


SELECT * FROM users_pwd, users_info, users_login WHERE userpwd.users='';