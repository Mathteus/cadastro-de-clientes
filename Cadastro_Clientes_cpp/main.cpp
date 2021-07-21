#include <iostream>
#include <cstdlib>

#include "BancoFuncionarios.h"

using namespace std;

int main(){
    BancoFuncionarios bf;
    string resposta = bf.lerdb();
    cout << resposta << endl;
    return 0;
}
