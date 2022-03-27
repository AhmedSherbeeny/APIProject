### APIProject

#### Discrption

This project was a graduation project in my course i was taken, it's an API project working depend on a class library, you give it numbers and it will calculate the numbers with three function, the Avarage, the Smallest number, the Largest number.
  
The Class libarary carry the fuuncations, and the API value controller carry the business logic. and i make the class library as a dependancy.
  
#### Code View

In the below points i will put parts from the code i use in the Class libarary and the API

  * Class Library

     1- Average

        public int Average(int[] nums)
        {
            int total = 0;
            foreach (var num in nums)
            {
                total += num;
            }
            return total / nums.Count();
        }

     2- Smallest
     
             public int Smallest(int[] nums)
        {
            int smallest = nums[0];
            foreach (var num in nums)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            return smallest;
        }
        
     3- Largest
     
             public int Largest(int[] nums)
        {
            int largest = nums[0];
            foreach (var num in nums)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            return largest;
        }
 
 Also i created a unit test for the class library to check the code covarage, please check the below unit test for Average funcation
 
         [TestMethod]
        public void TestAverrage()
        {
            //Arrange

            Math math1 = new Math();
            var nums = new int[] { 10, 33, 50, 2, 100 };

            //Act

            var result = math1.Average(nums);

            //Assert

            Assert.IsTrue(result == 39);

        }
        
The below screenshot from the unit test result

![image](https://user-images.githubusercontent.com/97340280/160281501-6eeb8cf6-1d2d-4dec-ba3f-3ec1c68d926f.png)

        
I used Azure Pipeline to run a CI on the Class Library, and store the package on Nuget.org.

![image](https://user-images.githubusercontent.com/97340280/160281290-c5d78098-0a26-4f6b-a628-a6679dd0bd1a.png)

You can find my Class Library package on https://www.nuget.org/packages/SherbeenyLibrary/

  * API

    1- Average
    
            [HttpGet("/average")]
        public int Average([FromQuery] int[] nums)
        {
            return math.Average(nums);
        }
        
    2- Smallest
    
            [HttpGet("/smallest")]
        public int Smallest([FromQuery] int[] nums)
        {

            return math.Smallest(nums);
        }
        
    3- Largest
    
            [HttpGet("/largest")]
        public int Largest([FromQuery] int[] nums)
        {
            return math.Largest(nums);
        }
    }
    



