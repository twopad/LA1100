# Projekt-Dokumentation

Warnebold

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.08.2022      | 0.0.1   | Ich habe User Stories erstellt und datu die Testfälle. |
| 30.08.2022      | 0.0.2   |  Ich habe das Spiel programmiert.|
| 06.09.2022      | 0.0.3  |   Ich habe eine maximale Anzahl an Versuchen hinzugefügt.|

## 1 Informieren

### 1.1 Ihr Projekt

Ich programiere ein Spiel, indem sich das Program eine zufällige Zahl zwischen 1-100 ausdenkt, danach kann man die ausgedenkte Zahl erraten.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                     |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss                | Funktional     | Als Progrmierer möchte ich dass, das Program eine zufällige Zahl wischen 1-100 generiert|
| 2    | muss                | Funktional     | Als Spieler möchte ich die zufällige Zahl erraten. |
| 3    |  muss                | Funktional     | Als spieler möchte ich sehen ob die, von mir, eingegebene Zahl Richtig oder Falsch ist um weitr zu spielen.  |
| 4     | kann             | Funktional     |Als Spieler möchte ich vom Program wissen, ob die erratene Zahl zu Gross oder zu klein ist, damit ich weiter raten kann. |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Program generiert eine zufällige Zahl.               | Starten      | Zufallszahl zwischen 1-100 erstellt          |
| 2.1 | Zahl erraten.             | 1        |   Richtig/Falsch                | 
| 2.2 | Maximal 5 versuche | 5 mal 1 | Verloren, alle Versuche verbraucht. Die Zahl War: |
| 2.3 | Keine Zahl einggeben  | abc  | Error. Zahl erneut eingeben  |
| 3.1 | Ich möchte wissen ob meine Zahl zu gross oder zu klein ist        | 50      | zu gross/zu klein                  |
 

### 1.4 Diagramme

![grafik](https://user-images.githubusercontent.com/110892623/186124023-ec2b2f40-fea1-40c2-98d5-69d69562c284.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  30.08.2022     |   Warnebold        |  Zufallszahl generieren            |   20min            |
| 2.A |  30.08.2022     | Warnebold  |   Zufallszahl und eingabe vergleichen        |  30min         | 
| 2.B | 06.09.2022 | Warnebold | Eine maximal Anzahl von Versüchen | 20min |
| 2.C | 06.09.2022 | Warnebold | wenn keine Zahl eingegeben wird soll es erneut fragen | 45min |
| 3.A | 30.08.2022     | Warnebold  |   ausgabe zu gross oder zu klein        |  30min         | 

Total: 
185min

## 3 Entscheiden

Genug Zeit nehmen

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |                   
| 1.A     |  30.08.2022     |   Warnebold       |   20min            |      15min             |
|  2.A    | 30.08.2022       |   Warnebold   |     30min          |     30min              |
| 2.B | 06.09.2022 | Warnebold | 20min | 10min |
| 2.C | 06.09.2022 | Warnebold | 45min | 75min |
|  3.A    | 30.08.2022       |  Warnebold        |   30min            |     25min              |



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 30.08.2022      | True     |   Warnebold     |
| 2.1  | 30.08.2022      |  True        |  Warnebold      |
| 2.2 | 06.09.2022 | True | Warnebold |
| 2.3 | 06.08.2022 | False | Warnebold |
| 3.1 | 30.08.2022 | True | Warnebold |

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    | Ich musste eine Zufälligezahl eingeben, habe aber Buchstaben eigegeben.      |  Buchstaben       |   Stürzt ab                |      Stürzt ab           |
| II   |  Ich musste eine Zufälligezahl eingeben, habe aber Dezimalzahlen eigegeben.  |  Dezimalzahlen    |   Stürzt ab                |      Stürzt ab           |



## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
