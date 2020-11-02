import { User } from './user.model';
import { Category } from './category.model';

export interface Quiz {
    quizId: number;
    userId: string;
    description: string;
    imageUrl: string;
    user: User;
    categoryId: number;
    category: Category;
}