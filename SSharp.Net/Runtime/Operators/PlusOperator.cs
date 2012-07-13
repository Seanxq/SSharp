﻿using System;

namespace Scripting.SSharp.Runtime.Operators
{
  /// <summary>
  /// Implementation of plus operator
  /// </summary>
  public class PlusOperator : BinaryOperator
  {
    public PlusOperator() :
      base("+")
    {
      RegisterEvaluator<string, string>((x, y) => x + y);
      RegisterEvaluator<string, Int16>((x, y) => x + y.ToString());
      RegisterEvaluator<string, Int32>((x, y) => x + y.ToString());
      RegisterEvaluator<string, Int64>((x, y) => x + y.ToString());
      RegisterEvaluator<string, float>((x, y) => x + y.ToString());
      RegisterEvaluator<string, Decimal>((x, y) => x + y.ToString());

      RegisterEvaluator<Decimal, Decimal>((x, y) => x + y);
      RegisterEvaluator<Decimal, Int16>((x, y) => x + y);
      RegisterEvaluator<Decimal, Int32>((x, y) => x + y);
      RegisterEvaluator<Decimal, Int64>((x, y) => x + y);
      RegisterEvaluator<Decimal, double>((x, y) => (double)x + y);
      RegisterEvaluator<Decimal, float>((x, y) => (float)x + y);
      RegisterEvaluator<Decimal, string>((x, y) => x.ToString() + y);

      RegisterEvaluator<Int16, Decimal>((x, y) => x + y);
      RegisterEvaluator<Int32, Decimal>((x, y) => x + y);
      RegisterEvaluator<Int64, Decimal>((x, y) => x + y);
      RegisterEvaluator<double, Decimal>((x, y) => x + (double)y);
      RegisterEvaluator<float, Decimal>((x, y) => x + (float)y);

      RegisterEvaluator<Int16, string>((x, y) => x.ToString() + y);
      RegisterEvaluator<Int16, Int16>((x, y) => x + y);
      RegisterEvaluator<Int16, Int32>((x, y) => x + y);
      RegisterEvaluator<Int16, Int64>((x, y) => x + y);
      RegisterEvaluator<Int16, double>((x, y) => x + y);
      RegisterEvaluator<Int16, float>((x, y) => x + y);

      RegisterEvaluator<Int32, string>((x, y) => x.ToString() + y);
      RegisterEvaluator<Int32, Int16>((x, y) => x + y);
      RegisterEvaluator<Int32, Int32>((x, y) => x + y);
      RegisterEvaluator<Int32, Int64>((x, y) => x + y);
      RegisterEvaluator<Int32, double>((x, y) => x + y);
      RegisterEvaluator<Int32, float>((x, y) => x + y);

      RegisterEvaluator<Int64, string>((x, y) => x.ToString() + y);
      RegisterEvaluator<Int64, Int16>((x, y) => x + y);
      RegisterEvaluator<Int64, Int32>((x, y) => x + y);
      RegisterEvaluator<Int64, Int64>((x, y) => x + y);
      RegisterEvaluator<Int64, double>((x, y) => x + y);
      RegisterEvaluator<Int64, float>((x, y) => x + y);

      RegisterEvaluator<double, string>((x, y) => x.ToString() + y);
      RegisterEvaluator<double, Int16>((x, y) => x + y);
      RegisterEvaluator<double, Int32>((x, y) => x + y);
      RegisterEvaluator<double, Int64>((x, y) => x + y);
      RegisterEvaluator<double, double>((x, y) => x + y);
      RegisterEvaluator<double, float>((x, y) => x + y);

      RegisterEvaluator<float, string>((x, y) => x.ToString() + y);
      RegisterEvaluator<float, Int16>((x, y) => x + y);
      RegisterEvaluator<float, Int32>((x, y) => x + y);
      RegisterEvaluator<float, Int64>((x, y) => x + y);
      RegisterEvaluator<float, double>((x, y) => x + y);
      RegisterEvaluator<float, float>((x, y) => x + y);
    }
  }
}