import { Category } from './category.model';
import { User } from './user.model';
export interface Quiz {
    quizId: number;
    name: string;
    description: string;
    imageUrl: string;
    userId: number
    user: User;
    categoryId: number;
    category: Category;
}
