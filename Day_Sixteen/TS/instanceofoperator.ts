class car{
    model:string;
    constructor(model:string)
    {
        this.model=model;
    }
}

const carobj= new car('Honda');
console.log(carobj instanceof car);
