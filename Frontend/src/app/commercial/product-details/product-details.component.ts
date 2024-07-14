import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-product-details',
  standalone: true,
  imports: [CommonModule, MatInputModule, MatFormFieldModule, FormsModule],
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {
  totalAmount: number = 0;
  getProductDetails: any[] = [];
  displayedColumns: string[] = ['imgpath', 'price', 'quantity', 'description'];
  quantityBought: number = 0;
  enteredUsername: string = ''; 
  defaultQuantity: number = 1;

  constructor(private route: ActivatedRoute, private router: Router) {}

  ngOnInit(): void {
    this.ProductDetails();
  }

  ProductDetails(): void {
    const localCart = localStorage.getItem('localCart');
    if (localCart) {
      this.getProductDetails = JSON.parse(localCart);
      this.totalAmount = this.getProductDetails[0].price;
    }
  }

  onQuantityChange(event: any, element: any): void {
    const quantity = event.target.value;
    if (quantity > 0) {
      this.totalAmount = quantity * element.price;
      this.quantityBought = quantity;
    }
  }

  addToCart() {
    const isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
    const loggedInUsername = localStorage.getItem('username');
    const enteredUsername = this.enteredUsername;

    if (!isLoggedIn) {
      alert('Please log in first.');
      this.router.navigate(['/login']);
      return;
    }

    if (loggedInUsername !== enteredUsername) {
      alert('The entered username does not match the logged-in user.');
      return;
    }

    this.processOrder(loggedInUsername);
  }

  processOrder(username: string) {
    let productOrders = JSON.parse(localStorage.getItem('ProductOrder') || '[]');
    const newOrder = {
      id: productOrders.length + 1,
      productId: this.getProductDetails[0].id,
      TotalAmount: this.totalAmount,
      Quantity: this.quantityBought,
      UserId: username,
      OrderDate: new Date().toISOString()
    };
    productOrders.push(newOrder);
    localStorage.setItem('ProductOrder', JSON.stringify(productOrders));
    this.router.navigate(['commercial/dashboard']);
  }



  logout() {
    localStorage.removeItem('isLoggedIn');
    localStorage.removeItem('username');
    this.router.navigate(['/login']);
  }
}