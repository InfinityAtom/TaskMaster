# Project Charter - "TaskMaster"

### 1. Project Purpose (Scopul proiectului)

Scopul proiectului este de a dezvolta o aplicație de gestionare a sarcinilor (listă de activități) pentru platforma web și mobilă, folosind .NET Blazor și MAUI. Aplicația va permite utilizatorilor să adauge, organizeze și partajeze sarcinile lor într-un mod simplu și eficient.

### 2. Measurable Project Objectives and Success Criteria (Obiective măsurabile și criterii de succes)

- Aplicația va permite utilizatorilor să gestioneze sarcinile cu funcții de adăugare, ștergere și modificare a stării lor.
- Funcționalitățile trebuie să fie accesibile atât pe web, cât și pe mobil.
- Sincronizarea datelor între aplicația web și mobilă trebuie să fie în timp real și fără erori.
- Succesul proiectului va fi măsurat prin testarea beta cu un nivel de satisfacție a utilizatorilor de minimum 80%.

### 3. High-level Requirements (Cerințe de nivel înalt)

- Utilizatorii vor putea crea și edita sarcini.
- Sarcinile vor avea statusuri de tip: Upcoming, Overdue, Completed, Canceled.
- Funcționalități suplimentare:
  - memento-uri,
  - sarcini recurente,
  - partajare între utilizatori (prin Email).
- Interfață prietenoasă și accesibilă, disponibilă pe web și mobil.

### 4. High-level Project Description, Boundaries, and Key Deliverables (Descriere, limite și livrabile majore)

- **Descriere**: "TaskMaster" este o aplicație pentru gestionarea activităților zilnice. Utilizatorii vor putea gestiona și partaja sarcini printr-o interfață intuitivă.
- **Limite**: Aplicația va fi limitată la funcționalitățile cerute și nu va include module avansate de analiză sau raportare.
- **Livrabile cheie**:
  - Aplicația web complet funcțională.
  - Aplicația mobilă sincronizată cu cea web.
  - Documentația completă (specificații, plan de proiect).

### 5. Overall Project Risk (Riscuri majore)

- **Risc tehnic**: Posibile probleme de sincronizare între aplicația web și cea mobilă.
- **Risc de timp**: Posibile întârzieri în integrarea API-urilor.
- **Risc de utilizare**: Dacă interfața nu este suficient de intuitivă, utilizatorii ar putea întâmpina dificultăți.

### 6. Summary Milestone Schedule (Etape și termene majore)

- **02.10.2024**: Stabilirea proiectului, a tematicii și a membrilor echipei.
- **16.10.2024**: Dezvoltarea primei variante a Project-Charter-ului, a User Stories & Use Cases și a instrumentelor de dezvoltare ce vor fi folosite.
- **30.10.2024**: Dezvoltarea interfeței utilizatorului în .NET Blazor și MAUI.
- **13.11.2024**: Dezvoltarea funcționalităților aplicației. Crearea bazei de date pentru utilizatori.
- **27.11.2024**: Migrarea bazei de date în Cloud (Microsoft Azure) și actualizarea codului sursă conform noilor locații din Cloud.
- **04.12.2024**: Testarea finală a tuturor funcționalităților aplicației; Ultimele retușuri înainte de Deploy.
- **11.12.2024**: Lansarea aplicației. Prezentarea oficială (v1.0).

### 7. Preapproved Financial Resources (Resurse financiare aprobate)

Resursele financiare vor fi folosite pentru hosting, licențe software și infrastructură cloud necesară pentru dezvoltare și sincronizare.

### 8. Key Stakeholder List (Lista stakeholder-ilor cheie)

- Echipa de dezvoltare (frontend și backend).
  - Fabian Pavel VELICEA
  - Constantin Liviu Florin GRECU
  - Valentin Cosmin ILIE
  - Daniel Cristian LUCA
- Managerul de proiect.
  - Fabian Pavel VELICEA
- Echipa de testare.
  - Grupa 4LF612

### 9. Project Approval Requirements (Cerințe de aprobare)

Proiectul va fi considerat un succes dacă toate funcționalitățile sunt implementate și testate cu succes, iar utilizatorii beta raportează un nivel de satisfacție de peste 80%. Echipa de management și clientul vor decide succesul final al proiectului.

### 10. Project Exit Criteria (Criterii de ieșire)

Proiectul va fi considerat finalizat odată ce toate livrabilele au fost predate și aprobate. În caz de întârzieri majore, proiectul poate fi ajustat sau întrerupt dacă depășește bugetul sau termenele.

### 11. Name and Authority of the Sponsor or Other Person(s) Authorizing the Project Charter (Sponsorul proiectului și nivelul de autorizare)

- **Sponsori**: Corneliu ZAHARIA, Universitatea “Transilvania” din Brașov
  - **Autoritate**: Sponsorul are responsabilitatea finală pentru aprobare și evaluare a performanței echipei în cadrul proiectului.
