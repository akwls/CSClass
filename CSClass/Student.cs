namespace CSClass
{
    class Student
    {
        // 학생 이름
        public string name;

        // 학생 성적
        public int grade;

        // 학생 객체 출력 메서드
        public override string ToString()
        {
            return this.name + " : " + this.grade;
        }


    }
}