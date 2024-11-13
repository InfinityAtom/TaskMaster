# User Stories & Use Cases

## User Stories:

1. **Adăugare sarcină**:
   - Ca utilizator, vreau să pot adăuga o sarcină în lista mea de activități, astfel încât să îmi pot organiza mai bine lucrurile pe care trebuie să le fac.
   - **Criterii de acceptare**:
     - Utilizatorul poate adăuga un titlu și o descriere pentru sarcină.
     - Utilizatorul poate seta un termen limită pentru sarcină.

2. **Modificare sarcină**:
   - Ca utilizator, vreau să pot edita o sarcină existentă, astfel încât să pot ajusta informațiile în funcție de nevoile mele.
   - **Criterii de acceptare**:
     - Utilizatorul poate schimba titlul, descrierea și termenul unei sarcini.

3. **Ștergere sarcină**:
   - Ca utilizator, vreau să pot șterge o sarcină din listă, astfel încât să pot menține lista curată și relevantă.
   - **Criterii de acceptare**:
     - Utilizatorul poate elimina o sarcină definitiv.

4. **Setare status sarcină**:
   - Ca utilizator, vreau să pot marca o sarcină ca fiind "Upcoming", "Overdue", "Completed" sau "Canceled", pentru a ține evidența progresului.
   - **Criterii de acceptare**:
     - Utilizatorul poate alege una dintre cele patru statusuri pentru fiecare sarcină.

5. **Sortare sarcini**:
   - Ca utilizator, vreau să pot sorta sarcinile în funcție de status sau dată, astfel încât să văd prioritățile mai ușor.
   - **Criterii de acceptare**:
     - Sarcinile pot fi sortate după termen sau status (Upcoming, Overdue, etc.).

6. **Memento-uri pentru sarcini**:
   - Ca utilizator, vreau să primesc notificări pentru sarcinile ce urmează să devină scadente, astfel încât să nu uit de ele.
   - **Criterii de acceptare**:
     - Utilizatorul poate primi notificări cu privire la sarcinile care sunt pe cale să expire.

## Use Cases (Cazuri de utilizare):

1. **Crearea unei sarcini**:
   - **Actor principal**: Utilizatorul
   - **Descriere**: Utilizatorul apasă pe un buton de „Adăugare sarcină” și introduce detaliile noii sarcini (titlu, descriere, termen). Apasă pe „Salvează”, iar sarcina apare în lista de activități.
   - **Precondiții**: Utilizatorul trebuie să fie în interfața principală a aplicației.
   - **Scenariu de succes**: Sarcina este creată și afișată în lista de activități.

2. **Modificarea unei sarcini**:
   - **Actor principal**: Utilizatorul
   - **Descriere**: Utilizatorul selectează o sarcină din lista de activități și apasă pe „Editare”. Schimbă informațiile necesare și apasă „Salvează”.
   - **Precondiții**: Sarcina trebuie să existe deja în listă.
   - **Scenariu de succes**: Modificările sunt salvate și sarcina este actualizată în listă.

3. **Ștergerea unei sarcini**:
   - **Actor principal**: Utilizatorul
   - **Descriere**: Utilizatorul selectează o sarcină din listă și apasă pe „Șterge”. Confirmă acțiunea, iar sarcina dispare din listă.
   - **Precondiții**: Sarcina trebuie să existe în listă.
   - **Scenariu de succes**: Sarcina este eliminată din aplicație.

4. **Schimbarea statusului unei sarcini**:
   - **Actor principal**: Utilizatorul
   - **Descriere**: Utilizatorul selectează o sarcină și o marchează ca "Upcoming", "Overdue", "Completed" sau "Canceled".
   - **Precondiții**: Sarcina trebuie să existe în listă.
   - **Scenariu de succes**: Statusul sarcinii se schimbă și este afișat corespunzător.

5. **Primirea unui memento pentru o sarcină**:
   - **Actor principal**: Utilizatorul
   - **Descriere**: Aplicația trimite o notificare atunci când o sarcină este pe cale să devină scadentă, conform setărilor utilizatorului.
   - **Precondiții**: Utilizatorul trebuie să aibă activat sistemul de memento-uri și să existe sarcini cu termen apropiat.
   - **Scenariu de succes**: Utilizatorul primește notificarea înainte de termenul stabilit.

6. **Sortarea sarcinilor**:
   - **Actor principal**: Utilizatorul
   - **Descriere**: Utilizatorul apasă pe o opțiune de sortare (de ex., după status sau dată). Sarcinile sunt rearanjate conform criteriului ales.
   - **Precondiții**: Utilizatorul trebuie să aibă mai multe sarcini în listă.
   - **Scenariu de succes**: Sarcinile sunt afișate conform ordinii alese de utilizator.
