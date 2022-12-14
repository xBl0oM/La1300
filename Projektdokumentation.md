
# Projekt-Dokumentation



Gruppe Ice Cream
Noah Meier, Mohamad Amaraya, John Broder, Leon Dakaj, Jan Frey

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|1.12.2022|0.0.1| Wir haben das Thema azsgewählt und auch die User Storys, Testfälle und das Diagramm erstellt. |
|8.12.2022|0.0.2| Wir haben das Planen gemaht und angefangen zu Programmieren.|
|15.12.2022|0.0.3|Wir haben den Code beendet und verbessert und eine Präsentation über unser Thema gehalten|

## 1 Informieren

### 1.1 Ihr Projekt

Wir Programmieren ein Mathe Quiz, bei dem man eine bestimmte anzahl an Aufgaben in einer bestimmten Zeit lösen muss

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|1|Muss|Funktional|Als User möchte ich eine Wilkommens-Page haben|
|2|Muss|Funktional|Als User möchte ich mein Thema wählen können|
|3|Muss|Funktional|Als User möchte ich die Schierigkeit des Themas wählen können |
|4|Muss|Qualität|Als User möchte ich eingeben, wie viel Zeit ich zur verfügung haben will|
|5|Muss|Funktional|Als User möchte ich einen klaren Timer sehen|
|6|Muss|Qualität|Als User möchte ich, dass Eingaben als richtig oder falsch eingespeichert werden|
|7|Muss|Qualität|Als User möchte ich ein Gratulation erhalten, wenn ich alle fragen richtig eingegeben habe|
|8|Muss|Qualität|Als User möchte ich Punkte für richtige Aufgaben erhalten oder bei falschen Aufgaben abzug erhalten|
|9|Kann |Qualität|Als User möchte ich ein Leaderboard sehen|
|10|Kann|Qualität|Als User möchte ich die Wahl haben, einen erneuten Versuch zu starten|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |User startet das Programm|-|Wilkommens-Page|
| 1.2  |Wilkommens-Page ist angezeigt |-|Einleitung|
|1.3|Einleitung ist angezeigt|User akzeptiert  |Quiz startet |
|2.1|User hat Quiz gestartet|-| Drop-Down Liste mit verschiedenen Themen|
|2.2|User hat Quiz gestartet|User wählt Thema|Beispiel wird angezeigt|
|2.3|User hat Quiz gestartet|User wählt Thema|Frage, ob User sicher ist|
|3.1|User hat Thema gewählt|-| Bestätigung des Themas|
|3.2|User hat das Thema gewählt|-| Frage nach Schwierigkeit|
|3.3|User hat das Thema gewählt|Wahl der Schwierigkeit|Beispiel für Schwierigkeit|
|4.1|Schwierigkeit gewählt|-|Uhr wird angezeigt|
|4.2|Schwierigkeit gewählt|-|Frage nach der angabe der Zeitdauer|
|4.3|Schwierigkeit gewählt|Eingabe der Zeitdauer|Die Zeit wird gespeichert|
|5.1|Zeit wurde eingegeben|-|Auswahl zwischen digitaler und normaler Uhr|
|5.2|Zeit wurde eingegeben|Eingabe der Auswahl|Gewählte Uhr wird gespeichert|
|5.3|Zeit wurde eingegeben|-|Uhr ist ersichtlich|
|6.1|Quiz beginnt|Eingabe der Lösung|Grüner Haken|
|6.2|Quiz beginnt|Eingabe der falschen Lösung|rotes X|
|6.3|Quiz beginnt|-|Eingaben werden gespeichert|
|7.1|Aufgaben wurden erledigt|-|Überprüfung der erledigung|
|7.2|Aufgaben wurden erledigt|-|Alle Aufgaben Richtig gelöst|
|7.3|Aufgaben wurden erledigt|-|Gratulation wird angezeigt|
|8.1|Aufgaben werden gelöst|Ergebnis|Speichern und kontrollieren|
|8.2|Aufgaben werden gelöst|-|Wenn Richtig punkte hinzufügen|
|8.3|Aufgaben werden gelöst|-|Wenn falsch punkte abziehen|
|9.1|Aufgaben wurden gelöst|-|Punkte werden gespeichert|
|9.2|Aufgaben wurden gelöst|-|Neues Pop-Up Fenster wird angezeigt|
|9.3|Aufgaben wurden gelöst|-|Leaderboard wird angezeigt|
|10.1|Leaderboard wird angezeigt|-|Frage nach erneutem Versuch|
|10.2|Leaderboard wird angezeigt|Erneut spielen/Abbrechen|Frage, ob der User sicher ist|
|10.3|Leaderboard wird angezeigt|Ja/Nein|Programm wird neu gestartet/beendet|



### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/111044215/205022048-065fe768-46e3-4fb7-bf51-ca5eaefa5324.png)

![image](https://user-images.githubusercontent.com/111044215/205022254-a7fc970e-7399-428c-9183-40435e65b961.png)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
|1|22.12.2022|Meier, Broder| Die Willkommenspage wird auf Forms programmiert|45 min|
|2 |22.12.2022|Frey,Dakaj,Meier,Broder,Amraya| Mehrere Themen werden programmiert die man dann auswählen kann und dass dan ein Beispiel angezeigt wird und gefragt wird ob man sich sicher ist.|120min |
|3|22.12.2022| Frey,Dakaj,Meier,Broder,Amraya | Programmieren das es verschiedene Schwierigkeitsgrade gibt,man zwischen den auswählen kann und dann wieder ein Beispiel kommt und gefragt wird ob man sich sicher ist diesen Schwierigkeitsgrad zu wählen. |45min|
|4|22.12.2022|Frey,Dakaj,Meier,Broder,Amraya|Ein Timer wird programmiert, den man selber einstellen kann bevor man die Aufgabe beginnt,damit man bischen Druck hat.|90min|
|5|22.12.2022|Frey,Dakaj,Meier,Broder,Amraya|Der Timer auf den Screen, auf dem die Aufgaben sind, sichtbar machen.|45min|
|6|22.12.2022|Frey,Dakaj,Meier,Broder,Amraya|richtig oder falsch programmieren wenn man eine Aufgabe beantwortet hat.|90min|
|7|22.12.2022|Frey,Dakaj,Meier,Broder,Amraya|Eine Gratulation programmieren die angezeigt wird wenn man alle Fragen richtig beantwortet hat.|90min|
|8|22.12.2022|Frey,Dakaj,Meier,Broder,Amraya|Programmieren das man Punkte pro richtige oder bei falschen Antworten minus bekommt.|90min|
|9|22.12.2022|Frey,Dakaj,Meier,Broder,Amraya|Programmieren eines Leader Bords das, sobald die Aufgaben fertig sind, angezeigt wird.|90min|
|10|22.12.2022|Frey,Dakaj,Meier,Broder,Amraya|Programmieren, ob man weiterspielen kann oder beenden will.|45min|

## 3 Entscheiden

Wir haben uns am 8.12.2022 dazu entschieden mit dem programmieren anzufangen.
Wir haben uns am 15.12.2022 dazu entschieden die Planungs Nummern 4,5,8 und 9 nicht auszuführen, weil wir keine Zeit mehr haben.
Wir haben uns am 22.12.2022 dazu entschieden das Meier,Frey,Dakaj und Amraya sich um den Lernbericht kümmern, wärend Broder sich um die fertigstellung des Githubs sorgt. 
## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
|1|8.12.2022|Broder,Meier|45min|60min|
|2|8.12.2022|Frey,Dakaj,Meier,Broder,Amraya|120min|180min|
|3|15.12.2022|Frey,Dakaj,Meier,Broder,Amraya|90min|60min|
|4|15.12.2022|Frey,Dakaj,Meier,Broder,Amraya|90min|wurde nicht erstellt 0 min|
|5|15.12.2022|Frey,Dakaj,Meier,Broder,Amraya|90min|wurde nicht erstellt 0 min|
|6|15.12.2022|Frey,Dakaj,Meier,Broder,Amraya|90min|60min|
|7|15.12.2022|Frey,Dakaj,Meier,Broder,Amraya|90min|60min|
|8|15.12.2022|Frey,Dakaj,Meier,Broder,Amraya|90min|wurde nicht erstellt 0 min|
|9|15.12.2022|Frey,Dakaj,Meier,Broder,Amraya|90min|wurde nicht erstellt 0 min|
|10|15.12.2022|Frey,Dakaj,Meier,Broder,Amraya|45min|wurde nicht erstellt 0 min|

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
|1|15.12.2022|Die Willkomenspage wird eingeblendet.|Frey|
|2a|15.12.2022|Themen werden eingeblendet.|Frey|
|2b|15.12.2022|Beispiel wird nicht angezeigt.|Frey|
|2c|15.12.2022|Es wird nicht gefragt ob man sich sicher ist.|Frey|
|3|15.12.2022|Schwierigkeitsgrad kann ausgewählt werden.|Frey|
|3b|15.12.2022|Beispiel wird nicht angezeigt.|Frey|
|3c|15.12.2022|Es wird nicht gefragt ob man sich sicher ist.|Frey|
|4|15.12.2022|Wurde nicht erledigt.|Frey|
|5|15.12.2022|Wurde nicht erledigt.|Frey|
|6|15.12,2022|Wenn dass Resultat richtig ist wird es grün angestrichen und wenn es Falsch ist rot.|Frey|
|7|Wenn man alle Fragen richtig beantwortet wird eine extra Seite eingeblendet, auf der Herzlichen Glückwunsch steht.|Frey|
|8|15.12.2022|Wurde nicht erledigt.|Frey|
|9|15.12.2022|Wurde nicht erledigt.|Frey|
|10|15.12.2022|Es wird keine Frage eingeblendet.|Broder|

### Zitat
Allgemein ging unsere Arbeit gut, allerdings hatten wir mehrere Organisatorische Probleme, die uns bisschen zurückgehalten haben. Darum konnten wir leider nicht all unsere Ziele fertigstellen. Wir sind trotzdem stolz auf das was wir am Schluss bekommen haben. Das Grund Programm läuft reibungslos und wir sind pünktlich fertig geworden.

## 6 Auswerten

(https://github.com/xBl0oM/La1300/blob/main/Lernbericht.md)
