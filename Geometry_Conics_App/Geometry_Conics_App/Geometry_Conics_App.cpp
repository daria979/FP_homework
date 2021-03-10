
#include <iostream>
#include <iomanip>
using namespace std;

 void Conica(float D,float d)
{
    cout << "---> Ecuatia generala reprezinta : ";
    if (D != 0)
    {
        if (d > 0)
            if (D < 0)
                cout << "E L I P S A --->  x^2/a^2 + y^2/b^2 - 1 = 0";
            else
                cout << "multimea vida";
        if (d < 0)
            cout << "H I P E R B O L A --->  x^2/a^2 - y^2/b^2 - 1 = 0";
        if (d == 0)
            cout << "P A R A B O L A ---> y^2 - 2px = 0";
    }
    else
    {
        if (d > 0)
            cout << "punct ---> x^2 + y^2 = 0";
        if (d < 0)
            cout << "drepte concurente in C0 ---> a^2x^2 - y^2 = 0";
        if (d == 0)
            cout << "drepte paralele (sau multimea vida) ---> x^2 - 1 = 0";
    }

}
 void Unghi(float a11, float a22,float a12)
 {
     cout << "---> Determinam unghiul teta ,notat 0: " << endl << endl;
     if (a11 = a22)
     {
         cout << "Unghiul 0 este de 45 grade (pi/4)"<<endl;
         cout << "=> sin0 = cos0 =radical(2)/2";
     }
         
     else
     {
         cout << "Ne folosim de urmatoarele relatii: "<<endl;
         cout << "(1) tg20 = 2a12/(a11-a22) = inlocuire in formula" <<endl;
         cout << "(2) tg(a+b) = tg(0+0) = (tg0+tg0)/(1-tg0*tg0) = 2tg0/(1-tg^20)" << endl;
         cout << "Din egalarea celor 2 relatii => aflarea lui 0 (mereu alegem pe cel pozitiv)"<<endl<<endl;
         cout << "Stim ca tg0 = sin0/cos0"<<endl;
         cout << "Egalam sin0/cos0 cu valoarea tangentei apoi din fundamentala (sin^0+cos^0=1) aflam cos0 si sin0 " << endl<<endl;
         cout << "Unghiul de rotatie este dat de punctul cu coord. M(sin0,cos0) aproximativ." << endl;
         cout << "Dreapta x` va trece prin punctul M si origine."<<endl;
         cout << "Dreapta y` va trece prin origine si este eprpendiculara pe x`.";
     }
 }
 void Translatie_Rotatie()
 {
     cout << "---> Ecuatiile de rotatie si translatie: " << endl << endl;
     cout << "Se face un sistem inlocuind cu sin0 si cos0 apoi se desfac paranteze etc: " << endl;
     cout << "x = x`cos0 - y`sin0" << endl;
     cout << "y= x`sin0 + y`cos0" << endl;
     cout << "Nota!!! Trebuie sa se reduca termenii cu x`y` dupa care FORMAM PATRATE." << endl<<endl;
     cout << "Ajungem la ecuatiile de translatie:" << endl;
     cout << "x``=(ce e in paranteza ridicata la a doua)" << endl;
     cout << "y``=(ce e in paranteza ridicata la a doua)" << endl ;
     cout << "Se inlocuieste cu acestea in cuatia anterioara, apois e imparte cu termenul liber " << endl << endl;
     cout << "Egalam pe rand cu 0 pe x`` si y`` de unde => x` si y`" << endl;
     cout << "Acesta va fi punctul N(x`,y`) aproximativ de pe dreptele x`Oy`"<<endl;
     cout << "Dreapta y`` va trece prin x` si este paralela cu y`, iar dreapta x`` este perpendiculara pe y`` si trece prin  y`" << endl;
 }
 void Final()
 {
     cout << "---> Pasii finali:" << endl << endl;
     cout << "Radical din a si b (numitorii de la ecuatia de translatie) repr. focarele, punctele dupa care vom construi conica." << endl;
     cout << "(In cazul elipsei si a hiperbolei. Pt parabola trebuie doar sa treci dincolo de egal pt a fi sub forma y^2=2px)" << endl;
     cout << "Aceste focare sunt situatie in sistemul x``Oy``"<<endl;
     cout << "NOTA: Daca semnele sunt pe dos inseamna ca si desenul va fi 'pe dos'";
 }
int main()
{

    cout << "-> Forma generala a unei conice este: "<<endl<<"a11X^2 + 2a12XY + a22Y^2 + 2a13X + 2a23Y + a33 = 0"<<endl<<endl;
    cout <<"-> Introduceti parametrii conicei:\n";
    float a11, a12, a22, a13, a23, a33;
    cout << "a11 X^2: "; cin >> a11;
    cout << "a12 XY: "; cin >> a12 ;
    cout << "a22 Y^2: "; cin >> a22;
    cout << "a13 X: "; cin >> a13;
    cout << "a23 Y: "; cin >> a23;
    cout << "a33: "; cin >> a33;
    cout << endl;

    a12 = a12 / 2;
    a13 = a13 / 2;
    a23 = a23 / 2;

    float I = a11 + a22;
    float d = a11 * a22 - a12 * a12; 
    float D = a11 * a22 * a33 + a12 * a23 * a13 + a12 * a23 * a13 - a13 * a22 * a13 - a11 * a23 * a23 - a12 * a12 * a33;

    char d1[] = "d(delta mic) = ";
    char D1[] = "Delta(triunghi) = ";
    int space1 = strlen(d1);
    int space2 = strlen(D1);
    cout << "I = a11 + a22 = " << I;
    cout << endl << endl;

    cout <<"d(delta mic) = | a11 a12 | =  " << d<<endl;
    for (int i = 0; i < space1; i++)
        cout << " ";
    cout << "| a12 a22 |"<<endl<<endl;

    cout << "Delta(triunghi) = | a11 a12 a13 | = " << D<<endl;
    for (int i = 0; i < space2; i++)
        cout << " ";
    cout << "| a12 a22 a23 | " << endl;
    for (int i = 0; i < space2; i++)
        cout << " ";
    cout << "| a13 a23 a33 |" << endl<<endl;

    float rad2 = sqrt(2);
    float rad3 = sqrt(3);
    float rad5 = sqrt(5);
    cout << "---------> VALORI RADICALI:";
    cout << "rad2 = " << fixed << setprecision(2) << rad2<<" ";
    cout << "rad3 = " << fixed << setprecision(2) << rad3 << " ";
    cout << "rad5 = " << fixed <<setprecision(2) << rad5 << endl << endl;

    Conica(D,d);
    cout << endl<<endl;
   
    Unghi(a11, a22, a12);
    cout << endl<<endl;

    Translatie_Rotatie();
    cout << endl << endl;

    Final();
    cout << endl << endl;
        

}

