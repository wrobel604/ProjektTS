# ProjektTS

Implementacja protokołu tekstowego.

Model komunikacji: 1<->1

Pola nagłówka protokołu reprezentowane jako pary
> klucz: wartość;

Działanie programów:
* Klient wysyła do serwera typ operacji oraz liczby, natomiast serwer zwraca wynik i status operacji
* Klient i serwer przesyłają między sobą nagłówki z tymi samymi kluczami
* Klucze występujące w nagłówku
  - Identyfikator
  - Status - zawiera 
  - Operacja - polecenie jakie ma wykonać serwer
  - Czas - czas wysłania komunikatu
  - Liczby - tablica liczb, na których będzie przeprowadzana operacja
