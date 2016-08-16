/*
*
*	- nome:   CHECKUPDATE
*	- azione: crea tabella
*	- autore: RPGames
*	
*	- descrizione:
*	Crea una tabella 'checkupdate', dove vengono conservate
*	le informazioni dei software (la versione caricata on-line).
*	In questo modo il software installato localmente potrà controllare
*	se sul server sono presenti aggiornamenti.
*	
*/

-- crea la tabella userpwd
CREATE TABLE checkupdate
(
	id				serial,
	idnome			char(40),				-- nome di riconoscimento del software
	
	nome			char(40),				-- nome del software
	versione		char(20),				-- versione del software caricata sul server
	descrizione		text,					-- breve descrizione del software del quale si richiede l'aggiornamento
	image_url		text,					-- url dell'immagine del software
	download_url	text,					-- url del software scaricabile

	CONSTRAINT checkupdate_pkey_id PRIMARY KEY (id)       -- mantieni ordinato l'indice
);

-- indicizza l'indice id
CREATE INDEX checkupdate_i_id
   ON checkupdate (id);