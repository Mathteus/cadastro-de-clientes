#ifndef BANCOFUNCIONARIOS_H_INCLUDED
#define BANCOFUNCIONARIOS_H_INCLUDED

#include "Funcionarios.h"
#include <fstream>
#include <vector>
#include <string>
#include <conio.h>
#include <iostream>

using namespace std;

class BancoFuncionarios {
private:
    vector<string> nomes;
    vector<string> senhas;
    vector<string>::iterator it;

public:
    BancoFuncionarios(/* args */);
    ~BancoFuncionarios();
    void lerFuncionarios();
    string lerdb();
    void gravar(string _name);

};

BancoFuncionarios::BancoFuncionarios(/* args */){
}

BancoFuncionarios::~BancoFuncionarios(){
}

void BancoFuncionarios::lerFuncionarios(){

}

string BancoFuncionarios::lerdb(){
    fstream leitor;
    string linha="";
    char verif=' ';
    string nome="";
    string senha="";
    //vector<string> nomes;
    //vector<string> senhas;
    int v=0,cont, i=0;
    leitor.open("db/file2.txt", ios::in);
    if(leitor.is_open()){
        while(getline(leitor, linha)){
            verif = linha[i];
            while(verif != ';'){
                verif = linha[i];
                if(verif == ';'){
                    nomes.push_back(nome);
                    cout << nome << endl;
                    nome="";
                    i++;
                } else {
                    nome += verif;
                    i++;
                }
            }
            verif=linha[i];
            while(verif != ';'){
                verif = linha[i];
                if(verif == ';'){
                    senhas.push_back(senha);
                    cout << senha << endl;
                    senha="";
                    //verif = ' ';
                    i=0;
                } else {
                    senha += verif;
                    i++;
                }
            }
            cout << endl;
        }
        cout << "Arquivo existe...\n";
    } else {
        cout << "Arquivo nao existe...\n";
    }
    leitor.close();
    for(int i=0;i<nomes.size();i++){
        cout << "Names " << i << ": " << nomes[i] << endl;
    }
    for(int i=0;i<senhas.size();i++){
        cout << "Senhas " << i << ": " << senhas[i] << endl;
    }
    return nome;
}

void BancoFuncionarios::gravar(string _name){
    ofstream escritor;
    //escritor.open("db/file2,txt",);
    escritor.close();
}



#endif // BANCOFUNCIONARIOS_H_I
