using System;

namespace homework1 {
    class Program {
        static void Main(string[]args) {

            Console.Clear();
            Console.Write("Your number : ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Your agency : ");
            string agency = Console.ReadLine();
            Console.WriteLine("-------------------------");
            
            int result1 = 0;
            int rest1, rest2, rest3, rest4, rest5;
            int pos1 = (int)num/100000;
            rest1 = num - (pos1 * 100000);
            int pos2 = (int)rest1/10000;
            rest2 = rest1 - (pos2 * 10000);
            int pos3 = (int)rest2/1000;
            rest3 = rest2 - (pos3 * 1000);
            int pos4 = (int)rest3/100;
            rest4 = rest3 - (pos4 * 100);
            int pos5 = (int)rest4/10;
            rest5 = rest4 - (pos5 * 10);
            int pos6 = (int)rest5/1;

            if (num < 100000 || num > 999999){
                result1 = result1 + 1;
            }
            /*  "If don't need 0 in any position"

            else if (pos2 == 0){
                result1 = result1 + 1; 
            }       
            else if (pos3 == 0){
                result1 = result1 + 1;
            }
            else if (pos4 == 0){
                result1 = result1 + 1;
            }
            else if (pos5 == 0){
                result1 = result1 + 1;
            }
            else if (pos6 == 0){
                result1 = result1 + 1;
            }*/
            else {
                switch (agency){
                    case "CIA":
                        int CIA_1 = (int)pos6 % 3;
                        if (CIA_1 != 0){
                            result1 = result1 + 1;
                        }
                        else if (pos5 == 1 || pos5 == 3 || pos5 == 5){
                            result1 = result1 + 1;
                        }
                        else if (pos3 < 6 || pos3 == 8){
                            result1 = result1 + 1;
                        }
                        break;

                    case "FBI":
                        int FBI_2 = (int)pos4 % 2;
                        int FBI_3 = (int)pos2 % 2;
                        if (pos1 < 4 || pos1 > 7){
                            result1 = result1 + 1;
                        }
                        else if (FBI_2 != 0 || pos4 == 6){
                            result1 = result1 + 1;
                        }
                        else if (FBI_3 == 0){
                            result1 = result1 + 1;
                        }
                        break;

                    case "NSA":
                        int NSA_1 = 30 % pos6;
                        int NSA_21 = pos4 % 3;
                        int NSA_22 = pos4 % 2;
                        if (NSA_1 != 0){
                            result1 = result1 + 1;
                        }
                        else if (NSA_21 != 0 && NSA_22 == 0){
                            result1 = result1 + 1;
                        }
                        else if (pos1 != 7 && pos2 != 7 && pos3 != 7 && pos4 != 7 && pos5 != 7 && pos6 != 7 ){
                            result1 = result1 + 1;
                        }
                        break;

                    default:
                        result1 = result1 + 1;
                        break;
                }
            }
            
            bool final = result1 == 0;
            Console.WriteLine("{0}",final);
        }
    }
}
