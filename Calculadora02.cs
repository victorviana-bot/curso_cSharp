﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpUdemy_Secao04_Aulas {
    class Calculadora02 {

        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i <numbers.Length; i++) {
                sum += numbers[i];
                }
            return sum;
            }

        }
    }
