namespace CSClass
{
    class Product
    {
        public string name = "감자";
        public int price = 2000;

        // java와 달리 override 키워드 존재
        // 오류 방지.
        // @Override 어노테이션과 동일
        public override string ToString()
        {
            return this.name + " : " + this.price;
        }
    }
}