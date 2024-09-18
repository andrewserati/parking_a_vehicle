namespace ParkingAVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=== PARKING A VEHICLE ===\n");

                Console.WriteLine("Operador: Andrew\n");
                Console.WriteLine("Operações disponíveis:");
                Console.WriteLine("1 - Estacionar");
                Console.WriteLine("2 - Liberar");
                Console.WriteLine("3 - Listar");
                Console.WriteLine("4 - Encerrar");

                Console.Write("\nO que deseja fazer? Informe aqui: ");
                while (true)
                {
                    var choosedOperation = Console.ReadLine();

                    if (choosedOperation != null && int.TryParse(choosedOperation, out int choosedOperationNumber))
                    {
                        Console.WriteLine("A operação escolhida foi: " + choosedOperationNumber);
                        break;
                    }
                    Console.Write("Não foi possível escolher a operação... Informe novamente: ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
