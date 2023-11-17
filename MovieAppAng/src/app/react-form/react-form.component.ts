import { Component, OnInit } from '@angular/core';
import { FormBuilder,Validators } from '@angular/forms';
import { IMovie } from '../model/imovie';
@Component({
  selector: 'app-react-form',
  templateUrl: './react-form.component.html',
  styleUrls: ['./react-form.component.css']
})
export class ReactFormComponent implements OnInit {
  moviedata:IMovie


  constructor(private fb) { }

  ngOnInit() {
  }

}
