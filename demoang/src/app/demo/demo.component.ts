import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
  name:string='Tom'
  age:number=20
  fno:number=90
  sno:number=30
  city:string='Mumbai'
  Sum():number{
    return this.fno+this.sno
  }
  Show():void{
    alert('Name is '+ this.name+'Age is '+this.age)
  }
  constructor() { }

  ngOnInit() {
  }

}
