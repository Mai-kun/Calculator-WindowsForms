namespace Calculator.Utilities
{
    static class ConvertingTemperature
    {
        //Цельсий   - 0
        //Фаренгейт - 1 
        //Кельвин   - 2
        //Ранкин    - 3
        //Реомюр    - 4

        public static string Convert(double number, int selectedState1, int selectedState2)
        {
            switch (selectedState1)
            {
                case 0://Цельсий
                    switch (selectedState2)
                    {
                        case 0://Цельсий ++
                            return number.ToString();
                        case 1://Фаренгейт ++
                            return (number * 1.8 + 32.0).ToString();
                        case 2://Кельвин ++
                            return (number + 273.15).ToString();
                        case 3://Ранкин ++
                            return (number * 1.8 + 491.67).ToString();
                        case 4://Реомюр ++
                            return (number * 0.8).ToString();
                    }
                    break;

                case 1://Фаренгейт
                    switch (selectedState2)
                    {
                        case 0://Цельсий ++
                            return ((number - 32.0) * (5.0 / 9.0)).ToString();
                        case 1://Фаренгейт ++
                            return number.ToString();
                        case 2://Кельвин ++
                            return ((number - 32.0) * (5.0 / 9.0) + 273.15).ToString();
                        case 3://Ранкин ++
                            return (number + 459.67).ToString();
                        case 4://Реомюр ++
                            return (2.25 * number - 32.0).ToString();
                    }
                    break;

                case 2://Кельвин
                    switch (selectedState2)
                    {
                        case 0://Цельсий ++
                            return (number - 273.15).ToString();
                        case 1://Фаренгейт ++
                            return ((number - 273.15) * 1.8 + 32.0).ToString();
                        case 2://Кельвин ++
                            return number.ToString();
                        case 3://Ранкин ++
                            return ((number - 273.15) * 1.8).ToString();
                        case 4://Реомюр ++
                            return (0.8 * number - 218.0).ToString();
                    }
                    break;

                case 3://Ранкин
                    switch (selectedState2)
                    {
                        case 0://Цельсий ++
                            return ((5.0 / 9.0) * number - 273.15).ToString();
                        case 1://Фаренгейт ++
                            return (number - 459.67).ToString();
                        case 2://Кельвин ++
                            return (300 * number * (5.0 / 9.0)).ToString();
                        case 3://Ранкин ++
                            return number.ToString();
                        case 4://Реомюр ++
                            return ((number - 491.67) * 0.44444).ToString();
                    }
                    break;

                case 4://Реомюр
                    switch (selectedState2)
                    {
                        case 0://Цельсий ++
                            return (number * (10.0 / 8.0)).ToString();
                        case 1://Фаренгейт ++
                            return (2.25 * number + 32.0).ToString();
                        case 2://Кельвин ++
                            return (1.25 * number - 273.15).ToString();
                        case 3://Ранкин ++
                            return (number * 2.25 + 491.67).ToString();
                        case 4://Реомюр ++
                            return number.ToString();
                    }
                    break;
            }

            return "";
        }

    }
}
