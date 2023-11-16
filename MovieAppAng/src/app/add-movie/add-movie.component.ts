import { Component, OnInit } from '@angular/core';
import { IMovie } from '../model/imovie';
import { MovieserviceService } from '../services/movieservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-movie',
  templateUrl: './add-movie.component.html',
  styleUrls: ['./add-movie.component.css']
})
export class AddMovieComponent implements OnInit {
moviedata:IMovie={id:0,name:'', yearRelease : 0, rating:0}

  constructor(private ms:MovieserviceService,private route:Router) { }

  ngOnInit() {
  }

}
