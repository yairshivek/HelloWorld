using System;

namespace HelloVSCode
{
    
    public enum EnmGender {Male, Female}
    
    public class Student
    {
        public Student(int id)
        {
            _Id = id;
        }

        public Student(){}

        private int _Id;

        public string Name;

        private decimal _grade;
        public decimal Grade{
            get{
                return _grade;  
            } 
            set{
                if (value > 100) {
                    _grade = 100;
                }
                else{
                    _grade = value;
                }
            }
        } 
        public EnmGender Gender{get;  set;}
        
        public int GetId(){
            return _Id;
        }  

        public void SetId(int value){
            _Id = value;
        }
            
    }
}
