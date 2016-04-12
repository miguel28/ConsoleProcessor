#include <iostream>
#include <windows.h>

using namespace std;

int counter = 0;

int main()
{
    while(counter < 32768)
    {
        cout << counter++;
        cout << "aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbccccccccccccccc";
        cout << "ddddddddddddddddeeeeeeeeeeeeeeeeeefffffffffffffff";
        cout << "hhhhhhhhhhhhhhhhiiiiiiiiiiiiiiiiiijjjjjjjjjjjjjjj";
        cout << "kkkkkkkkkkkkkkkkllllllllllllllllllmmmmmmmmmmmmmmm";
        cout << endl;
        Sleep(20);
    }
    return 0;
}
