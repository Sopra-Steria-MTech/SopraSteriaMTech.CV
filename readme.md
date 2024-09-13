# Sopra Steria MTech programmeertest

Deze Visual Studio 2022 solution is bedoeld voor een programmeertest bij de intake van nieuwe Sopra Steria MTech ontwikkelaars.
De solution bestaat uit een .NET 8 api voor het beheer van een CV die wordt opgeslagen in een SQL database (localdb).
Deze api wordt gebruikt door een Angular en Blazor frond-end om het CV te tonen. 
Het is in deze front-ends ook mogelijk om een nieuwe foto voor het CV te uploaden.
De solution wordt na wijzigingen in de main branch, middels een GitHub Actions pipeline automatisch gebouwd en gedeployed.

Een werkende versie van de Agnular applicatie staat hier: https://lemon-bay-0dd512703.5.azurestaticapps.net/
\
De Blazor versie staat hier: https://mtech-cv-blazor.azurewebsites.net/
\
Hier vind je de api: https://mtech-cv-api.azurewebsites.net/

In de solution zijn expres fouten gemaakt in het design en in de programmacode.

Het verhaal is dat deze code is opgezet door een oud medewerker en moet worden beheerd en doorontwikkeld door de kandidaat.
De kandidaat krijgt een aantal dagen van te voren de link naar het GitHub project.

Het verloop van de test is als volgt:
1. De kandidaat doet in 15 minuten een peer review van deze code samen met een MTech collega.
2. Vervolgens bouwt hij/zij in 30 minuten een eenvoudige nieuwe functionaliteit of unit test in een pair-programming sessie met de MTech collega.
3. Tenslotte volgt een evaluatie van 10 minuten.

Bronvermelding:\
Het gebruikte CV template komt van: https://startbootstrap.com/theme/resume/
\
En de pasfoto komt van: https://thispersondoesnotexist.com/
