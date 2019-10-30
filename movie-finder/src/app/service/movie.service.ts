import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import  Movie  from '../../app/models/Movie';

const BASE_URL = "https://api.themoviedb.org/3/movie";
const API_KEY  = "?api_key=6682a735908aa3eb870f48b76e4ebf5d";

@Injectable()
export class MovieService {
  popularEndpoint = '/popular';
  theatersEndpoint = 'discover/movie?primary_release_date.gte=2018-07-15&primary_release_date.lte=2019-02-01';


  constructor(private http: HttpClient) { 

  }

  getPopular(){
    console.log((BASE_URL + this.popularEndpoint + API_KEY));
    
    return this.http.get<Movie[]>(BASE_URL + this.popularEndpoint + API_KEY);
    //return 'https://api.themoviedb.org/3/movie/550?api_key=6682a735908aa3eb870f48b76e4ebf5d'';
  }
  getTheaters(){
    return this.http.get<Movie[]>(BASE_URL + this.theatersEndpoint + API_KEY);
  }
  
}
