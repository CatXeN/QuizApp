import { Category } from './category.model';
import { User } from './user.model';
export interface Quiz {
    quizId: String;
    name: string;
    description: string;
    imageUrl: string;
    userId: number
    user: User;
    categoryId: String;
    category: Category;
}
