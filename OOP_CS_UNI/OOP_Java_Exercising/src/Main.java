//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
            Inventory inventory = new Inventory();
            Fruit fruit = new Fruit("Green", "Banana", 2);
            Weapon weapon = new Weapon("Sword",75, "Legolas", 2);
            inventory.addItem(fruit);
            inventory.addItem(weapon);
            inventory.displayInventory();



    }
}