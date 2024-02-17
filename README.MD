Korte beschrijving van ieder demo-project.

# B_ControlsDemo

* Toont hoe je het click-event van een Button gebruikt.
* Toont hoe je control zichtbaar en onzichtbaar kunt maken (zowel vanuit xaml als c#).
* (Geavanceerd) Toont de werking van de combobox en gebruikt  polymorfisme (``ComboBoxItem selectedItem = (ComboBoxItem)cmbData.SelectedItem;``) om geselecteerde element uit te lezen.
* Toont het gebruik van de MessageBox-klasse.
* (Oefening)Kan je een label met tekst toevoegen dat mee zichtbaar/onzichtbaar wordt samen met de Combobox.

# C1_CanvasTekenen

Merk in XAML op hoe we het Canvas eerste volledig wit maken maken mbv ``<SolidColorBrush Color="White" Opacity="0"/>`` . Doe je dit niet dan zal je niet kunnen tekenen op het canvas.

* Toont hoe we kunnen reageren op het bewegen van de muis (MouseMove event) om zo elementen aan het canvas toe te voegen wiens positie overeenkomt met die van de muis op dat moment (dat event werd afgevuurd).
* (Oefening) Kan je een button toe voegen die het canvas leegmaakt? (``paintCanvas.Children.Clear()``).

# C2_CanvasPolyline

* Toont het gebruik van het Loaded event om code te starten NADAT de volledige user interface is opgestart.
* (Geavanceerd) Gebruikt een Point collectie om punten te gebruiken als punten in een PolyLine object dat op het canvas zal getekend worden.


# D1_FileReading

* Toont de werking van de OpenFileDialog, een ingebouwde klasse die je kan gebruiken om aan de gebruiker te vragen met welk bestand moet gewerkt worden.
* Toont hoe een tekstbestand kan ingelezen worden en vervolgens de via een MessageBox getoond worden.

# D2_FileReading2

* Toont hoe je in XAML met behulp van de Grid-control meer gestructureerde UI's kunt ontwikkelen.
* Toont hoe je in XAML een scrollviewer "op" een control kunt plaatsen zodat deze automatische scrollbars krijgt indien nodig.
* Toont hoe je de MessageBox meer kan customizen naar je eigen wensen (aanpassen icoon, titel, knoppen, etc)
* Toont hoe je de inhoud van een tekst bestand in een tekstveld kunt tonen.
* Toont hoe je de inhoud van een tekstveld naar een bestand kunt wegschrijven.


# D3_FileReadingDrawing

* Toont hoe je een (tekst)bestand mee naar gecompileerde uitvoerfolder kunt sturen (zie Properties van datafile.txt in Properties explorer , dan de eigenschap "Copy to output directory" op "Copy Always" zetten)
* Toont hoe je een tekstbestand kunt "parsen" en gebruiken als invoer voor een pointscollectie, die je vervolgens op het canvas kan tekenen als een polyline.

# E_LiveCharts

Bij de start werd de LiveCharts bibliotheek als volgt toegevoegd:

1. Rechterklik in Solution Explorer op Dependencies van huidige project.
2. Kies "Manage Nuget packages" en klik op volgende scherm op "Browser".
3. Zoek naar "LiveCharts" en installeer LiveCharts.WPF van Beto R.
4. Voeg volgende lijn bovenaan in xaml toe ``xmlns:lvc="clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf"``
Zie voor meer informatie [https://v0.lvcharts.com/App/examples/v1/Wpf/Install](hier).

* (Geavanceerd) Toont het gebruikt van de LiveCharts.WPF bibliotheek om grafieken te visualiseren.

Nota: recent is LiveCharts2 gelanceerd. Deze is moderner, krachtig maar heeft (vermoedelijk) ook een iets hogere leercurve. Meer informatie [https://livecharts.dev/](hier)

# F1_DatabindingSimple

* (Geavanceerd) Toont hoe databinding kan gebruikt worden (in xaml) tussen twee controls.

# F2_DatabindingListbox

* (Geavanceerd) Toont het gebruik van een datatemplate om de individuele elementen van een listbox te databinden.