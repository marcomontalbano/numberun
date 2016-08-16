/*
*
*	- nome:   USERs_PWD	
*	- azione: inerisci utenti in tabella
*	- autore: Marco Montalbano
*	
*	- descrizione:
*	inserisce i dati dell'utente registrato all'interno della 'users_pwd'.
*	Nome utente, la password, il privilegio, il numero di registrazione
*	e una variabile booleana che è vera solo se l'utente ha confermato
*	la sua registrazione tramite l'e-mail.
*	(i dati completi dell'utente registrato vengono inseriti nella tabella
*	'users').
*	
*/


-- inserisci un riga di valori per la tabella
INSERT INTO users_pwd (users, passwords, privilegio, enabled, data, ora ) VALUES
(
	'marco153',			-- nome dell'utente
	' ',				-- password dell'utente
	'admin',			-- privilegio dell'utente
	true,				-- è true se l'account è abilitato
	'00/00/0000',
	'00.00.00'
);	-- Marco Montalbano