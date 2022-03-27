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
 

