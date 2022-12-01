
# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Gruppe Ice Cream
Noah Meier, Mohamad Amaraya, John Broder, Leon Dakaj, Jan Frey

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

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
|6|Mus|Qualität|Als User möchte ich, dass Eingaben als richtig oder falsch eingespeichert werden|
|7|Muss|Qualität|Als User möchte ich ein Gratulation erhalten, wenn ich alle fragen richtig eingegeben habe|
|8|Muss|Qualität|Als User möchte ich Punkte für richtige Aufgaben erhalten|
|9|Kann|Qualität|Als User möchte ich Punkte für falsche Aufgaben abgezogen bekommen|
|10|Kann |Qualität|Als User möchte ich ein Leaderboard sehen|
|11|Kann|Qualität|Als User möchte ich die Wahl haben, einen erneuten Versuch zu starten|


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

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
|3.3|User hat das Thema gewählt|Eingabe der Schwierigkeit|Beispiel für Schwierigkeit|
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


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
