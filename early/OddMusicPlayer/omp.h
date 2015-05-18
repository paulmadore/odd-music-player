#ifndef OMP_H
#define OMP_H

#include <QMainWindow>

namespace Ui {
class OMP;
}

class OMP : public QMainWindow
{
    Q_OBJECT

public:
    explicit OMP(QWidget *parent = 0);
    ~OMP();

private:
    Ui::OMP *ui;
};

#endif // OMP_H
