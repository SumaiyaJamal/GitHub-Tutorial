public class BasicMaths {  
    public double Add(double num1, double num2) {  
        return num1 + num2;  
    }  
    public double Substract(double num1, double num2) {  
        return num1 - num2;  
    }  
    public double divide(double num1, double num2) {  
        return num1 / num2;  
    }  
    public double Multiply(double num1, double num2) {  
        // To trace error while testing, writing + operator instead of * operator.  
        return num1 + num2;  
    }  
}  


1.	using System;  
2.	using Microsoft.VisualStudio.TestTools.UnitTesting;  
3.	using BasicMath;  

[TestMethod]  
4.	    public void Test_AddMethod() {  
5.	            BasicMaths bm = new BasicMaths();  
6.	            double res = bm.Add(10, 10);  
7.	            Assert.AreEqual(res, 20);  
8.	        }  
9.	        [TestMethod]  
10.	    public void Test_SubstractMethod() {  
11.	            BasicMaths bm = new BasicMaths();  
12.	            double res = bm.Substract(10, 10);  
13.	            Assert.AreEqual(res, 0);  
14.	        }  
15.	        [TestMethod]  
16.	    public void Test_DivideMethod() {  
17.	            BasicMaths bm = new BasicMaths();  
18.	            double res = bm.divide(10, 5);  
19.	            Assert.AreEqual(res, 2);  
20.	        }  
21.	        [TestMethod]  
22.	    public void Test_MultiplyMethod() {  
23.	        BasicMaths bm = new BasicMaths();  
24.	        double res = bm.Multiply(10, 10);  
25.	        Assert.AreEqual(res, 100);  
26.	    }  
27.	}  
