import { Component, OnInit } from '@angular/core';
import { MovieService } from '../movieservice/movie.service';

@Component({
  selector: 'app-listmovies',
  templateUrl: './listmovies.component.html',
  styleUrls: ['./listmovies.component.css']
})
export class ListmoviesComponent implements OnInit {
  moviedata:any[]=[]

  constructor(private ms:MovieService) { 
    this.ms.getAllMovies().subscribe(data=>{this.moviedata.push(...data)})
    console.log(this.moviedata)

  }


  ngOnInit() {
  }

}
