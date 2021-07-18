#include <iostream>
#include <cstdlib>

#include "BancoFuncionarios.h"

using namespace std;

int main(){
    string resposta = BancoFuncionarios::lerdb();
    cout << resposta << endl;
    return 0;
}
