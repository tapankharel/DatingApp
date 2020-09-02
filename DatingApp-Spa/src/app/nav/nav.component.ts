import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent implements OnInit {
  model: any = {};
  constructor(private authService: AuthService) {}

  ngOnInit(): void {}
  login() {
    this.authService.login(this.model).subscribe(
      (next: any) => {
        console.log('Logged in successfully');
      },
      (error) => {
        console.log(error);
      }
    );
  }
  LoggedIn() {
    let token = localStorage.getItem('token');
    return !!token;
  }
  Logout() {
    localStorage.removeItem('token');
    console.log('Logged out!');
  }
}
