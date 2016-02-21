#include "omp.h"
#include "ui_omp.h"

OMP::OMP(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::OMP)
{
    ui->setupUi(this);
}

OMP::~OMP()
{
    delete ui;
}
