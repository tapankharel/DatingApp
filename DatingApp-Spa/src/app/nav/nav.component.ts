import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { AlertifyService } from '../services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css'],
})
export class NavComponent implements OnInit {
  model: any = {};
  constructor(
    public authService: AuthService,
    private alertify: AlertifyService
  ) {}

  ngOnInit(): void {}
  login() {
    this.authService.login(this.model).subscribe(
      (next: any) => {
        this.alertify.success('Logged in successfully');
      },
      (error) => {
        this.alertify.error(error);
      }
    );
  }
  LoggedIn() {
    // let token = localStorage.getItem('token');
    // return !!token;
    return this.authService.LoggedIn();
  }
  Logout() {
    localStorage.removeItem('token');
    this.alertify.message('Logged out!');
  }
}
