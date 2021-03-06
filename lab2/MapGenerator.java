package bricks;
import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Graphics2D;

public class MapGenerator {
    public int map[][];
    public int brickWidth;
    public int brickHeight;

    public MapGenerator(int row, int col) {
        map = new int[row][col];

        for (int i = 0; i < map.length; i++) {//petla po dlugosci mapy
            for (int j = 0; j < map[0].length; j++) {
                map[i][j] = 1;//ustawiam widocznosc blokow na 1
            }
        }
        brickWidth = 540 / col;//szerokość blokow
        brickHeight = 150 / row;//wysokość blokow
    }

    public void draw(Graphics2D graphics2d, Color colorName) {
        for (int i = 0; i < map.length; i++) {
            for (int j = 0; j < map[0].length; j++) {
                if (map[i][j] > 0) {
                    graphics2d.setColor(colorName);
                    graphics2d.fillRect(j * brickWidth + 80, i * brickHeight + 50, brickWidth, brickHeight);

                    graphics2d.setStroke(new BasicStroke(4));//odstep miedzy blokami
                    graphics2d.setColor(Color.black);//kolor
                    graphics2d.drawRect(j * brickWidth + 80, i * brickHeight + 50, brickWidth, brickHeight);
                }
            }
        }
    }

    public void setBrickValue(int value, int row, int col) {
        map[row][col] = value;
    }
}
