import java.awt.EventQueue;
import java.awt.Graphics;
import javax.swing.JFrame;
import javax.swing.JPanel;
import java.awt.Color;

class Surface extends JPanel {

    private void doDrawing(Graphics g) {

        g.setColor (new Color(0, 191, 255));
        g.fillRect (0,0,900,500);
//słońce
        g.setColor (new Color(252, 212, 64));
        g.fillArc (600,20,80,80,0,360);
        g.drawLine (595,55,575,55);
        g.drawLine (640,105,640,125);
        g.drawLine (640,15,640,0);
        g.drawLine (685,60,705,60);
        g.drawLine (605,35,585,25);
        g.drawLine (620,20,605,5);
        g.drawLine (600,80,580,90);
        g.drawLine (615,100,600,120);
        g.drawLine (675,5,660,20);
        g.drawLine (705,25,675,35);
        g.drawLine (705,90,675,80);
        g.drawLine (675,120,660,100);

//chmury
        g.setColor (Color.white);
        g.fillArc (660,130,80,50,0,360);
        g.fillArc (690,110,70,50,0,360);
        g.fillArc (730,130,80,50,0,360);

        g.fillArc (50,50,80,50,0,360);
        g.fillArc (80,30,70,50,0,360);
        g.fillArc (100,40,80,50,0,360);

        g.fillArc (700,50,80,50,0,360);
        g.fillArc (740,30,70,50,0,360);
        g.fillArc (760,50,80,50,0,360);

//dom
        g.setColor (new Color(255,228,196));
        g.fillRect (200,150,150,300);
        g.fillRect (240,130,120,20);
        g.fillRect (360,130,150,20);
        g.setColor (Color.black);
        g.fillRect (200,140,10,350);
        g.setColor (new Color(255,228,196));
        g.fillRect (350,150,150,300);
        g.setColor (Color.black);
        g.fillRect (350,130,10,170);
        g.setColor (Color.black);
        g.fillRect (50,300,600,10);
        g.setColor (Color.black);
        g.fillRect (500,130,10,320);
        g.setColor (Color.black);
        g.fillRect (240,130,10,20);
        g.setColor (Color.black);
        g.fillRect (200,140,40,10);
        g.setColor (new Color(255,228,196));
        g.fillRect (60,310,140,150);
        g.setColor (new Color(255,228,196));
        g.fillRect (510,310,130,150);
        g.setColor (Color.black);
        g.fillRect (50,440,600,10);
        g.setColor (Color.black);
        g.fillRect (50,310,10,150);
        g.setColor (Color.black);
        g.fillRect (640,310,10,150);

//drzwi
        g.setColor (new Color(105,105,105));
        g.fillArc (260,336,81,25,0,180);
        g.fillRect (260,348,40,91);
        g.fillRect (300,348,41,91);
        g.setColor (Color.white);
        g.fillRect (263,353,36,85);
        g.fillRect (303,353,35,85);
//przycisk
        g.setColor (new Color(105,105,105));
        g.fillRect(350,386,5,5);
//barierka
        g.setColor (new Color(160,82,45));
        g.fillRect (510,270,146,7);
        g.fillRect (515,270,5,30);
        g.fillRect (525,270,5,30);
        g.fillRect (535,270,5,30);
        g.fillRect (545,270,5,30);
        g.fillRect (555,270,5,30);
        g.fillRect (565,270,5,30);
        g.fillRect (575,270,5,30);
        g.fillRect (585,270,5,30);
        g.fillRect (595,270,5,30);
        g.fillRect (605,270,5,30);
        g.fillRect (615,270,5,30);
        g.fillRect (625,270,5,30);
        g.fillRect (635,270,5,30);
        g.fillRect (645,270,5,30);
//trawa
        g.setColor (Color.green);
        g.fillRect (0,450,900,50);

//drzewo
        g.setColor (Color.red);
        int a [] = {740,770,780,790};
        int b [] = {450,300,300,450};
        g.fillPolygon (a, b, 4);
        g.setColor (Color.green);
        g.fillArc (710,300,120,80,0,360);
        g.fillArc (710,270,130,80,0,360);
        g.fillArc (720,240,110,100,0,360);
        g.fillArc (740,210,60,90,0,360);

//dach
        g.setColor (new Color(105,105,105));
        int c [] = {180,300,420};
        int d [] = {130,60,130};
        g.fillPolygon (c, d, 3);
        g.setColor (Color.black);
        int x [] = {180,300,420};
        int y [] = {130,60,130};
        g.drawPolygon (x, y, 3);
        g.setColor (new Color(105,105,105));
        int m [] = {315,550,550,320};
        int n [] = {70,70,130,130};
        g.fillPolygon (m, n, 4);
        g.setColor (Color.black);
        int q [] = {315,550,550,420};
        int z [] = {70,70,130,130};
        g.drawPolygon (q, z, 4);
        g.setColor (new Color(105,105,105));
        int k [] = {38,199,199};
        int l [] = {300,200,300};
        g.fillPolygon (k, l, 3);
        g.setColor (Color.black);
        int r [] = {38,199,199};
        int s [] = {300,200,300};
        g.drawPolygon (r, s, 3);

// okno u gory
        g.setColor (new Color(105,105,105));
        g.drawRect (400,180,60,8);
        g.fillRect (400,188,30,50);
        g.fillRect (430,188,31,50);
        g.setColor (Color.white);
        g.fillRect (402,190,26,46);
        g.fillRect (432,190,26,46);
//rolety w oknie góra
        g.setColor (new Color(105,105,105));
        g.drawRect( 402,191,55, 1);
        g.drawRect( 402,194,55, 1);
        g.drawRect( 402,197,55, 1);
        g.drawRect( 402,200,55, 1);
        g.drawRect( 402,203,55, 1);
        g.drawRect( 402,206,55, 1);
        g.drawRect( 402,209,55, 1);
// dolne okno
        g.setColor (new Color(105,105,105));
        g.drawRect (395,335,60,8);
        g.drawRect (395,335,60,10);
        g.fillRect (395,345,30,50);
        g.fillRect (425,345,31,50);
        g.setColor (Color.white);
        g.fillRect (398,347,26,46);
        g.fillRect (427,347,26,46);

// okno z lewej na pietrze
        g.setColor (new Color(105,105,105));
        g.drawRect (250,180,60,8);
        g.fillRect (250,188,30,50);
        g.fillRect (280,188,31,50);
        g.setColor (Color.white);
        g.fillRect (252,190,26,46);
        g.fillRect (282,190,26,46);

    }

    @Override
    public void paintComponent(Graphics g) {

        super.paintComponent(g);
        doDrawing(g);
    }
}
public class Lab1 extends JFrame {

    public Lab1() {

        initUI();
    }

    private void initUI() {

        add(new Surface());

        setTitle("rysunek w javie");
        setSize(916, 539);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

    public static void main(String[] args) {

        EventQueue.invokeLater(new Runnable() {

            @Override
            public void run() {
                Lab1 ex = new Lab1();
                ex.setVisible(true);
            }
        });
    }
}