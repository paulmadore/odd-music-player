#include "omp.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    OMP w;
    w.show();

    return a.exec();
}
