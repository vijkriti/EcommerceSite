import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import productsData from '../../core/data.json';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [CommonModule, MatCardModule, MatIconModule],
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  products: any[] = [];
  categories: any[] = [];
  brands: any[] = [];
  filteredProducts: any[] = [];
  selectedCategory: any[] = [];
  selectedBrand: any[] = [];
  c: any;
  b: any;

  constructor( private router: Router) {}

  ngOnInit() {
    this.products = (productsData as any).products;
    this.categories = (productsData as any).categories;
    this.brands = (productsData as any).brands;
    this.filteredProducts = this.products;
    this.updateProductQuantities();
  }

  updateProductQuantities() {
    type ProductOrder = {
      id: number;
      productId: number;
      TotalAmount: number;
      Quantity: number;
      UserId: string;
      OrderDate: string;
    };

    let productOrders: ProductOrder[] = JSON.parse(localStorage.getItem('ProductOrder') || '[]');
    productOrders.forEach((order: ProductOrder) => {
      let product = this.products.find(p => p.id === order.productId);
      if (product) {
        product.quantity -= order.Quantity;
        if (product.quantity < 0) {
          product.quantity = 0;
        }
      }
    });
  }

  filter() {
    this.filteredProducts = this.products.filter(product => 
      (this.c == product.categoryId) && (this.b == product.brandId));
    console.log(this.filteredProducts);
  }

  onCheckboxChange(event: any) {
    this.c = event.target.value;
  }

  onCheckChange(event: any) {
    this.b = event.target.value;
  }

  navigateTo(prod: any) {
    const isLoggedIn = localStorage.getItem('isLoggedIn') === 'true';
    if (isLoggedIn) {
      this.router.navigate(['commercial/details']);
      localStorage.setItem('localCart', JSON.stringify([prod]));
    } else {
      this.router.navigate(['auth/login']);
    }
  }

  logout() {
    localStorage.removeItem('isLoggedIn');
    localStorage.removeItem('username');
    this.router.navigate(['/login']);
  }
}
