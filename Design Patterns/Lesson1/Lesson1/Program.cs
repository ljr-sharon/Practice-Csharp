namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck(); // 創建MallardDuck實例
            mallard.display(); // 執行外觀
            mallard.PerformFly(); // 執行飛行
            mallard.PerformQuack(); // 執行叫聲

            Duck model = new ModelDuck(); // 創建ModelDuck實例
            model.display(); // 顯示外觀
            model.PerformFly(); // 執行飛行
            model.SetFlyBehavior(new FlyRocketPowered()); // 改變飛行為 火箭飛行
            model.PerformFly(); // 再次執行飛行
            model.PerformQuack(); // 執行叫聲

            Duck rubber = new RubberDuck(); // 創建RubberDuck實例
            rubber.display(); // 顯示外觀
            rubber.PerformFly(); // 執行飛行
            rubber.PerformQuack(); // 執行叫聲
            //((RubberDuck)rubber).PerformSqueak(); // 執行橡皮鴨的特有叫聲

            DecoyDuck decoy = new DecoyDuck(); // 創建DecoyDuck實例
            decoy.display(); // 顯示外觀
            decoy.PerformFly(); // 執行飛行
            decoy.PerformQuack(); // 執行叫聲


            Console.ReadLine(); // 等待用戶輸入以結束程序
        }
    }
}
