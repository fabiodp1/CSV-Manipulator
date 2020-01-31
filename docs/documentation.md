# Test di sviluppo Web App

### Descrizione

Documentazione per lo sviluppo di una applicazione web, test di candidatura presso NGS Spa.

### Requisiti Tecnologici

| **N°**   |      **DESCRIPTION**      |  **FLAG**  |
|:----------:|:-------------:|:------:|
|  |  **SERVER-SIDE** |  |
| 0 |    FW ASP.NET Core 3.1 MVC   |   Mandatory |
| 1 | C# > 7 |   Mandatory |
|  | **CLIENT-SIDE** |    |
| 0 | Vue.js |   Mandatory |
| 1 | TypeScript |   Mandatory |
| 2 | Webpack |   Mandatory |
|  | **OTHERS** |    |
| 0 | Dovrà essere rispettata la struttura richiesta dalla documentazione del progetto |   Mandatory |
| 1 | Dovranno essere rispettate le scelte stilistiche come da documentazione del progetto |   Mandatory |

### Requisiti Funzionali

| **N°**   |      **DESCRIPTION**      |  **FLAG** |
|:----------:|:-------------:|:------:|
| 0 |    I’utente deve poter facilmente caricare un file csv, potendo indicare se presenta degli header o meno   |   Mandatory |
| 1 | Il file dovrà essere elaborato e renderizzato graficamente tenendo conto della presenza o meno degli header |   Mandatory |
| 2 | l’utente potrà aggiungere/rimuovere colonne dalla tabella renderizzata |   Mandatory |
| 3 | l’utente potrà modificare le singole celle di dati e intestazioni delle colonne, fino al raggiungimento del risultato richiesto |   Mandatory |
| 4 | l’utente tramite un pulsante potrà salvare localmente il file modificato, in formato JSON |   Mandatory |
| 5 | Durante la modifica l’utente potrà usare funzioni aggiuntive per la pulizia dei dati, caratteri non richiesti ecc. |   Mandatory |

### Caratteristiche per il Successo

-   **Semplice e comprensibile**

    >Immediata la comprensione delle sue caratteristiche e funzionalità, rendendo la fruizione dell’utente immediata, anche senza una lettura della documentazione. Non sarà necessaria una formazione per il suo utilizzo da parte dei nuovi utenti, facendo risparmiare tempo e risorse.
-   **Scalabile, Modulare e Sicuro**

    >La parte server e client sono sviluppate come due entità distinte in comunicazione fra loro, in maniera modulare, permettendo una maggiore scalabilità e semplificando successive implementazioni.
          Sarà possibile un supporto “a comparti stagni”, permettendo di aggiungere nuove funzionalità o risolvere problematiche senza che venga modificato, intaccato o messo a rischio il comparto non coinvolto dalle modifiche.
-   **Libertà di Scegliere**

    >In seguito ad una semplice configurazione, il suo utilizzo da parte dell’utente non sarà vincolato ad un determinato servizio server, ma sarà possibile utilizzare quello che più lo soddisfa, senza dover rinunciare a tutte le funzionalità del CSV Manipulator e senza che venga intaccata la sua facilità e immediatezza di utilizzo.
-   **Leggero, Prestante e Cross-Platform**

    >Grazie alla tecnologia Vue.js e ASP.NET Core 3 il dispendio di risorse è molto limitato, rendendolo leggero, veloce e cross-platform, evitando la preoccupazione dell’incognita di doverlo far girare su altri OS o Browser, senza che vada ad intaccare o rallentare gli altri processi produttivi.

### Strumenti di Sviluppo

Per la parte server verrà utilizzato Visual Studio 2019, per la parte client Visual Studio Code.

### Analisi punti di forza/debolezza

#### Punti di forza:

-   Vue.js è un framework che si basa su JavaScript, già in parte conosciuto.
-   Conoscenza basi per controllo e debugging parte client-side.
-   Conoscenza CSS, basi di Bootstrap e CSS Grid per la parte grafica UI.
-   Familiarità con Visual Studio Code.
-   Numerose Documentazioni Online sulle tecnologie da usare

#### Punti di debolezza:

-   Metodologia di lavoro non conosciuta.
-   Vue.js ASP.NET Core 3, C\#, TypeScript, Webpack e loro utilizzo non conosciuti.
-   Parte Server non conosciuta.
-   Creazione REST API non conosciuta.
-   Visual Studio 2019 non conosciuto.
-   Poca familiarità con il Design Pattern Model View Controller.
-   Come assimilare e relazionare parte client con parte server non conosciuta.
-   Difficile stimare il tempo necessario per acquisire le skills richieste e portare a termine il progetto.

### Strategia Operativa

Tenendo conto dell’analisi dei punti forza/debolezza, dopo essermi procurato la documentazione necessaria (libri, video corsi e link utili), procederò all’acquisizione delle skills necessarie man mano che saranno necessarie, durante lo svolgimento delle task del progetto.

### Piano Operativo

Il progetto verrà suddiviso in una serie di task e subtasks in modo da creare un ordine operativo con cui organizzare e ordinare il lavoro da svolgere. La documentazione verrà mantenuta ordinata e aggiornata durante tutto lo svolgimento del progetto.

Durante la descrizione di ogni task verranno indicate in ordine cronologico le operazioni svolte e le problematiche riscontrate.


### Tasks
1.  **Sviluppo parte client-side**
    1.  Conoscenze base Vue.js
    2.  Creazione dell’interfaccia e suo funzionamento tramite Vue.js
    3.  Implementazione di TypeScript

2.  **Sviluppo parte server-side**
    1.  Configurazione generale dell’app MVC
    2.  Creazione REST API
    3.  Creazione metodo per il salvataggio in locale del file ricevuto tramite richiesta HTTP

3.  **Collegamento parte client con server**
4.  **Test**
6.  **Checklist operativa per test UAT**

\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

### Sviluppo parte Client-Side

-   **Acquisizione conoscenze di base Vue.js**

    Utilizzo corsi online per acquisire conoscenze base sul suo funzionamento e utilizzo.

-   **Analisi e scelta del tipo di interfaccia, l’UI dovrà avere:**

    -   Una barra di navigazione, che permetterà di spostarsi fra la Home, la Documentazione e i Contatti utili.
    -   Una parte centrale dove verrà renderizzato il corpo della pagina:
        - **prima dell'upload**
            -   una breve spiegazione.
            -   un campo su cui cliccare per la scelta del file.
            -   un checkbox per indicare se il file contiene headers o meno.
            -   un pulsate per avviare il parsing del file e la renderizzazione.
        - **dopo l'aupload**
            -   Scompaiono i campi precedenti
            -   Verrà renderizzata la tabella con i campi compilati:
                -   Se sono assenti gli header, ne verrano creati di provvisori da modificare.
                -   Ogni colonna avrà ai lati un’icona per cancellarla o aggiungerne un’altra alla destra
                    -   quella nuova avrà campi provvisori da compilare
                -   Le modifiche avverranno in maniera reattiva grazie al bi-directional binding di Vue.js.
            -   Comparirà il pulsante per il salvataggio in formato JSON.
    -   Un Footer semplice con un breve riferimento all’autore e un link alla pagina GitHub

#### Creazione dell’interfaccia e suo funzionamento tramite Vue.js

Viene inizializzato npm, il file di configurazione delle dipendenze, webpack e installati i pacchetti utili per l’hot-swap (webpack-cli webpack-dev-middleware webpack-dev-server webpack-hot-middleware), aggiunta nel file webpack.config.js la sezione devServer e modificato il file package.json con gli script richiesti. Inoltre installo in production cross-env in modo che non debba essere installato da un possibile collaboratore.

Viene suddivisa la pagina principale, utilizzando Grid CSS, nelle 3 zone prestabilite in cui Vue renderizzerà i vari componenti. Nella riga in alto verrà collocata la barra di navigazione nella centrale il contenuto e nell’ultima il footer.

Creazione della componente Home che conterrà il cuore dell’app. Una volta creati i componenti di base e i bottoni, procedo alla creazione dei metodi di caricamento del file e la loro elaborazione. Per il caricamento e lettura del file utilizzo FileReader.

Creato il metodo per il bottone di parsing e la renderizzazine della tabella, i metodi di eliminazione e aggiunta colonne e quello per la trasformazione del file in formato JSON, che verrà immagazzinato nella variabile JSONFIle.

Aggiunta la componente VueRouter per il routing fra le pagine dell’app.

Le funzioni base ci sono tutte, in seguito sarà da migliorare lo stile e le caratteristiche responsive della pagina.

Installo Axios che servirà all’invio della richiesta HTTP POST al server e configuro il metodo che verrà usato per la richiesta.

### Implementazione di TypeScript

Valutazione della configurazione più efficiente per l’installazione e utilizzo di TypeScript.

La sintassi Vue utilizzata fin adesso (Options API) per la creazione dei componenti vue potrebbe non essere compatibile, valuto se sia meglio utilizzare la Composition API (più complessa e ancora in beta, ma creata per essere compatibile con TypeScript, inoltre con Vue 3 sarà la sintassi utilizzata) o la Class API. Valuterò dopo una maggiore documentazione e diversi tentativi.

***Problematiche*** sembra più complesso del previsto il far riconoscere i file componente .vue a typescript, procederò cercando altri metodi, fra questo l’uso della vue-cli.

Dopo una prima installazione tramite vue-cli andata male, aggiungo il pacchetto @vue/cli-service al progetto e l’installazione va a buon fine.

Procedo alla valutazione dell’installazione con sintassi Class e senza per vedere le differenze. Con Options Syntax continua a dare errori, ho provato diversi metodi ma non riesce a riconoscere propriamente i file .vue.

Creo un altro branch e provo con la Class Syntax.

Continua a dare errore riguardante la versione di webpack installata, installo npm-check-updates e faccio un aggiornamento.

Probabilmente il problema risiede nella file json di configurazione, approfondisco lo studio e la comprensione di webpack e typescript tramite la documentazione.

Considerando che l’uso precedente delle CLI e i loro template ha portato a dei progetti con feature inutili e che non ho scelto personalmente, e considerando che una maggiore comprensione di queste tecnologie passa da una sperimentazione da 0, creo un altro progetto di prova con gli stessi file Vue e JS, ma senza configurazione webpack e Typescript.

Mi occuperò di una loro configurazione manuale.

Sono riuscito a configurare webpack per funzionare con vue.js, il problema attuale è che il bundle creato supera le dimensioni consigliate per una maggiore prestazione.
Il problema potrebbe essere risolto con l’utilizzo delle funzioni di chunking o di minification di webpack o babel.

Proverò con il plugin *UglifyJsPlugin* di webpack.

Problema non risolto, disinstallo *uglify* e *babel-loader*.

Si tratta solo di un messaggio, non compromette la renderizzazione e costruzione del progetto, annullo la comparsa delle notifiche con “hints: false”.

Procedo con l’installazione di *typescript* e di *ts-loader* e la configurazione del file di configurazione di webpack.

Dopo diversi giorni di continui errori dovuti al riconoscimento dei file .vue da parte di typescript, risolvo creando il file vue-shim.d.ts per l’ambient module declaration. TypeScript riconosce solo file statici come JS o JSON, per questo motivo non riconosce le estensioni .vue. Modifico la configurazione di webpack in modo che durante il binding venga attaccata l'estensione *ts* ai file *vue*.
Procedo alla dichiarazione dei types per le variabili dell’app.

***Problema risolto:*** Dopo una serie di tentativi con errori da parte di TypeScript, risolvo dichiarando la keyword *this* come *as any*.

\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_\_

### Sviluppo parte Server-Side

#### Configurazione generale dell’app MVC

Creo un progetto base tramite il template di Visual Studio per un ASP.NET Core 3 MVC Web App.

La predispongo per farle servire i file statici che saranno costruiti dalla web app (in seguito alla configurazione di webpack) nella cartella *wwwroot*, inserendo nel file *Startup.cs* il metodo *app.UseDefaultFiles()* assieme a *app.UseStaticFiles()*.

#### Creazione REST API

Dopo aver introdotto il progetto client all’interno di quello server, raccolgo informazioni e mi documento sul funzionamento dell’interfaccia server, come raccoglie le richieste http e come poter intervenire per poterne modificare il comportamento in modo da permetterle di ricevere la richiesta POST che conterrà il JSON, leggerla e salvarla in un file locale.

Tutto questo passa dalla comprensione di base del funzionamento delle REST API, la sintassi C#, ASP.NET Core 3 e loro funzionalità.

Creo un Model *SaveModel* e un Controller *ApiController* che si occuperà di ricevere la richiesta HTTP proveniente dal client e con un metodo *Save* passare il body della richiesta al modello. Quest’ultimo si occuperà del suo salvataggio in locale.

Non funziona come previsto, continuo con lo studio di C#.
