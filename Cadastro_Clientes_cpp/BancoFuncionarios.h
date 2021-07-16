#ifndef BANCOFUNCIONARIOS_H_INCLUDED
#define BANCOFUNCIONARIOS_H_INCLUDED

#include "Funcionarios.h"
#include <fstream>
#include <vector>
#include <cstring>
#include <conio.h>
#include <stdio.h>

using namespace std;

class BancoFuncionarios {
private:
    static ofstream escritor;
    static vector<Funcionarios> funcionario;

public:
    BancoFuncionarios(/* args */);
    ~BancoFuncionarios();
    static void lerFuncionarios();
    static string lerdb();

};

BancoFuncionarios::BancoFuncionarios(/* args */){
}

BancoFuncionarios::~BancoFuncionarios(){
}

void BancoFuncionarios::lerFuncionarios(){

}

string BancoFuncionarios::lerdb(){
    FILE *reader;
    fstream leitor;
    string linha="";
    char verif=' ';
    string nome="";
    int cont=0;
    leitor.open("db/file2.txt", ios::out|ios::app);
    reader = fopen("db/file2.txt", "rt");
    if(leitor.is_open()){
        while(getline(leitor, linha)){
            /*while(verif != ';'){
                verif = linha[cont];
                if(verif != ';') nome +=verif;
                cont++;
            }*/
            nome += linha;
            printf("%s\n",linha);
        }
    }
    return nome;
}



#endif // BANCOFUNCIONARIOS_H_I
