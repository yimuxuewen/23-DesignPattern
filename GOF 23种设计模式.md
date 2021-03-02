# 23种设计模式 #

## 从设计原则到设计模式 ##

### 1.针对接口编程，而不是针对实现编程

- 客户无需知道所使用对象的特定类型，只需知道对象拥有客户期望的接口

### 2.优先使用对象组合，而不是类继承

- 类继承通常为“白箱复用”，对象组合通常为“黑箱复用”。继承在某种程度上破坏了封装性，子类父类耦合度高；而对象组合则只要求被组合的对象具有良好定义的接口，耦合度低。

### 3.封装变化点

- 使用封装来创建对象之间的分界层，让设计者可以在分界层的一侧进行修改，而不会对另一侧产生不良的影响，从而实现层次间的松耦合。

### 4.使用重构得到模式

- 设计模式的应用不宜先入为主，一上来就使用设计模式是对设计模式的最大误用。没有一步到位的设计模式。敏捷软件开发实践提倡的“Refactoring to Patterbs”是目前普遍公认的最好的使用设计模式的方法。

## 具体设计原则 ##

### 1.单一职责原则

- 一个类只允许有一个职责，即只有一个导致该类变更的原因。

  解读：类职责的变化往往就是导致类变化的原因：也就是说如果一个类具有多种职责，就会有多种导致这个类变化的原因，从而导致这个类的维护变得困难。往往在软件开发中，随着需求的不断增加，可能会给原来的类添加一些本来不属于它的一些职责，从而违反了单一职责原则。如果我们发现当前类的职责不仅仅有一个，就应该将本来不属于该类真正的职责分离出去。不仅仅是类，函数也要遵循单一职责原则，即一个函数只做一件事情。如果发现一个函数里面有不同的任务，则需要将不同的任务以另一个函数的形式分离出去。

  优点：如果类与方法的职责划分的很清晰，不但可以提高代码的可读性，更实际性地更降低了程序出错的风险，因为清晰的代码会让bug无处藏身，也有利于bug的追踪，也就是降低了程序的维护成本。

### 2.开放封闭原则

- 一个软件实体，如类，模块和函数应该对外扩展开放，对内修改关闭。

  解读：用抽象构建框架，用实现扩展细节。不以改动原有类的方式来实现新需求，而是应该以实现事先抽象出来的接口（或具体类继承抽象类）的方式来实现。

  优点：开闭原则的优点在于可以在不改动原有代码的前提下给程序扩展功能。增加了程序的可扩展性，同时也降低了程序的维护成本。

### 3.里式替换原则

- 所有引用基类的地方必须能透明地使用其子类的对象，也就是说子类对象可以替换其父类对象，而程序执行效果不变。

  解读：在继承体系中，子类中可以增加自己特有的方法，也可以实现父类的抽象方法，但是不能重写父类的非抽象方法，否则该继承关系就不是一个正确的继承关系。	

  优点：可以检验继承使用的正确性，约束继承在使用上的泛滥。

### 4.依赖倒置原则

- 依赖抽象而不是依赖实现。抽象不应该依赖细节，细节应该依赖抽象。高层模块不能依赖低层模块，二者都应该依赖抽象。

  解读：针对接口编程，而不是针对实现编程。尽量不要从具体的类派生，而是以继承抽象类或实现接口来实现。关于高层模块与低层模块的划分可以按照决策能力的高低进行划分。业务层自然就处于上层模块，逻辑层和数据层自然就归类为底层。

  优点：通过抽象来搭建框架，建立类和类的关联，以减少类间的耦合性。而且以抽象搭建的系统要比以具体实现搭建的系统更加稳定，扩展性更高，同时也便于维护。

### 5.接口隔离原则

- 多个特定的客户端接口要好于一个通用性的总接口。

  解读：客户端不应该依赖它不需要实现的接口。不建立庞大臃肿的接口，应尽量细化接口，接口中的方法应尽量少。需要注意的是接口的力度也不能太小，如果过小，则会造成接口数量过多，使设计复杂化。

  优点：避免同一个接口里面包含不同类职责的方法，接口责任划分更加明确，符合高内聚低耦合的思想。

### 6.迪米特法则

- 一个对象应该对尽可能少的对象有接触，也就是只接触那些真正需要接触的对象。

  解读：迪米特法则也叫做最少知道原则，一个类应该只和它的成员变量，方法的输入，返回参数中的类作交流，而不应该引入其他的类（间接交流）。

  优点：实践迪米特法则可以良好地降低类与类之间的耦合，减少类与类之间的关联程度，让类与类之间的协作更加直接。

## 模式分类 ##

### 1.从目的来看

- 创建型：负责对象创建(工厂方法模式、抽象工厂模式、单例模式、建造者模式、原型模式)
- 结构型：处理类与对象间的组合(适配器模式、装饰器模式、代理模式、外观模式、桥接模式、组合模式、享元模式)
- 行为型：类与对象交互中的职责分配(策略模式、模板方法模式、观察者模式、迭代器模式、责任链模式、命令模式、备忘录模式、状态模式、访问者模式、中介者模式、解释器模式)

> **5 + 7 = 11；5个创建型，7个结构型，11个行为型**
>
> 抽工单建原			桥代理组装适配器，享元回家装饰外观			访问者写好策略备忘录，观察模板迭代的状态，命令中介解释责任链

### 2.从范围来看

- 类模式处理类与子类的静态关系
- 对象模式处理对象间的动态关系

----------

# 设计模式 #

### 1.单例模式

- 单例对象能保证在程序运行过程中，该对象只有一个实例存在。这样的模式有几个好处：

1. 某些类创建比较频繁，对于一些大型的对象，这是一笔很大的系统开销。
2. 省去了new操作符，降低了系统内存的使用频率，减轻GC压力。
3. 有些类如交易所的核心交易引擎，控制着交易流程，如果该类可以创建多个的话，系统完全乱了。（比如一个军队出现了多个司令员同时指挥，肯定会乱成一团），所以只有使用单例模式，才能保证核心交易服务器独立控制整个流程

```
public sealed class Singleton
    {
        /* 持有私有静态实例，防止被引用，此处赋值为null，目的是实现延迟加载 */
        private static Singleton instance = null;
        private static readonly object locks = new object();

        /* 私有构造方法，防止被实例化 */
        private Singleton()
        {
        }

        /* 静态工程方法，创建实例 */
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (locks)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }


        /* 如果该对象被用于序列化，可以保证对象在序列化前后保持一致 */
        public Object readResolve()
        {
            return instance;
        }
    }

```

 ```
/// <summary>
/// 内部有静态方法时，会先创建对象,即使不需要创建对象，在使用静态方法时也会创建对象
/// </summary>
public sealed class Singleton
    {
        /* 持有私有静态实例，防止被引用，此处赋值为null，目的是实现延迟加载 */
        private static readonly Singleton instance = null;

        /* 私有构造方法，防止被实例化 */
        private Singleton()
        {

        }

        /* 静态方法，在类创建时只初始化一次 */
        static Singleton()
        {
            instance = new Singleton();
        }

        /* 静态工程方法，创建实例 */
        public static Singleton GetInstance
        {
            get
            {
                return instance;
            }
        }

        /* 如果该对象被用于序列化，可以保证对象在序列化前后保持一致 */
        public Object readResolve()
        {
            return instance;
        }
    }

 ```

 ```
/// <summary>
/// 内部有静态方法时，不会先创建对象
/// </summary>
public sealed class Singleton
    {
        /* 私有构造方法，防止被实例化 */
        private Singleton()
        {

        }

        /* 静态工程方法，创建实例 */
        public static Singleton GetInstance
        {
            get
            {
                return InternalSingleton.instance;
            }
        }

        /* 如果该对象被用于序列化，可以保证对象在序列化前后保持一致 */
        public Object readResolve()
        {
            return instance;
        }

        /// <summary>
        /// 内部嵌套类
        /// </summary>
        private class InternalSingleton
        {
            internal static readonly Singleton instance = null;
            /* 静态方法，在类创建时只初始化一次 */
            static InternalSingleton()
            {
                instance = new Singleton();
            }
        }
    }
 ```

### 2.建造者模式

建造者模式将一个复杂对象的生成责任作了很好的分配。它把构造过程放在指挥者的方法中，把装配过程放到具体建造者类中。建造者模式的产品之间都有共通点，但有时候，产品之间的差异性很大，这就需要借助工厂方法模式或抽象工厂模式。另外，如果产品的内部变化复杂，Builder的每一个子类都需要对应到不同的产品去做构建的动作、方法，这就需要定义很多个具体建造类来实现这种变化。

- 创建者模式只用于“分步骤构建一个复杂的对象”。在这其中“分步骤”是一个稳定的算法，而复杂对象的各个部分则经常变化。

- 变化点在哪里，封装哪里-创建者模式主要在于应对“复杂对象各个部分”的频繁需求变动。其缺点在于难以应对“分步骤构建算法”的需求变动。

- 抽象工厂模式解决“系列对象”的需求变化，创建者模式解决“对象部分”的需求变化。

- 创建者模式通常和组合模式组合使用

 ```
 
    class Customer
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();
 
            director.Construct(b1);// 老板叫员工去组装第一台电脑
   
            Computer computer1 = b1.GetComputer();// 组装完，组装人员搬来组装好的电脑
            computer1.Show();
           
            director.Construct(b2);// 老板叫员工去组装第二台电脑
            Computer computer2 = b2.GetComputer();
            computer2.Show();
 
            Console.Read();
        }
    }
    public class Director
    { 
        public void Construct(Builder builder)// 组装电脑
        {
            builder.BuildPartCPU();
            builder.BuildPartMainBoard();
        }
    }
 
    public class Computer// 电脑类
    {
        private IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("电脑开始在组装.......");
            foreach (string part in parts)
            {
                Console.WriteLine("组件"+part+"已装好");
            }
 
            Console.WriteLine("电脑组装好了");
        }
    }
 
    public abstract class Builder// 抽象建造者
    {
        public abstract void BuildPartCPU();// 装CPU
        public abstract void BuildPartMainBoard();// 装主板       
        public abstract Computer GetComputer();// 获得组装好的电脑
    }
    public class ConcreteBuilder1 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU1");
        }
        public override void BuildPartMainBoard()
        {
            computer.Add("Main board1");
        }
        public override Computer GetComputer()
        {
            return computer;
        }
    }
    public class ConcreteBuilder2 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU2");
        }
        public override void BuildPartMainBoard()
        {
            computer.Add("Main board2");
        }
        public override Computer GetComputer()
        {
            return computer;
        }
    }
 ```

### 3.工厂方法

- 定义一个用于创建对象的接口，让子类决定实例化哪一个类。工厂方法使得一个类的实例化延迟到子类。
- 工厂方法模式的两种情况：一是创建类是一个抽象类且它不提供它所声明的工厂方法的实现；二是创建的是一个具体的类且它提供一个工厂方法的缺省实现。
- 工厂方法可以带参数的。
- 工厂的作用并不仅仅只是创建一个对象，它还可以做对象的初始化，参数的设置等
- 以下情况，适用于工厂方法模式：

1. 当一个类不知道它所必须创建的对象的类；
2. 当一个类希望由它的子类来指定它所创建的对象；
3. 当类将创建对象的职责委托给多个帮助子类中的某一个，并且你希望将哪一个帮助子类是代理者这一信息局部化时。

 ```
   public class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("请输入第一数：");
            int numberA = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二数：");
            int numberB = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            string operation = Console.ReadLine();

            Factory factory = null;
			//switch后期通过反射修改
            switch (operation)
            {
                case "+":
                    factory=new AddFactory();
                    break;
                case "-":
                    factory = new SubFactory();
                    break;
                case "*":
                    factory = new MulFactory();
                    break;
                case "/":
                    factory = new DivFactory();
                    break;
                default:
                    break;
            }

            Calculation calculation = factory.CreateCalculation();
            calculation.NumberA = numberA;
            calculation.NumberB = numberB;
            Console.WriteLine($"{numberA} {operation} {numberB} = {calculation.GetResult()}");
        }

    }


    #region 工厂类方法
    public abstract class Factory
    {
        public abstract Calculation CreateCalculation();
    }

    public class AddFactory : Factory
    {
        public override Calculation CreateCalculation()
        {
            return new AddCalculation();
        }
    }

    public class SubFactory : Factory
    {
        public override Calculation CreateCalculation()
        {
            return new SubCalculation();
        }
    }

    public class MulFactory : Factory
    {
        public override Calculation CreateCalculation()
        {
            return new MulCalculation();
        }
    }
    public class DivFactory : Factory
    {
        public override Calculation CreateCalculation()
        {
            return new DivCalculation();
        }
    }
    #endregion

    #region 计算类
    public abstract class Calculation
    {
        protected int _numberA;
        public int NumberA { get => _numberA; set => _numberA = value; }

        protected int _numberB;
        public int NumberB { get => _numberA; set => _numberA = value; }

        public abstract int GetResult();

    }

    public class AddCalculation : Calculation
    {
        public override int GetResult()
        {
            return base._numberA + base._numberB;
        }
    }

    public class SubCalculation : Calculation
    {
        public override int GetResult()
        {
            return base._numberA - base._numberB;
        }
    }

    public class MulCalculation : Calculation
    {
        public override int GetResult()
        {
            return base._numberA * base._numberB;
        }
    }

    public class DivCalculation : Calculation
    {
        public override int GetResult()
        {
            if (base._numberB == 0)
            {
                throw new Exception("被除数不能为0");
            }
            return base._numberA / base._numberB;
        }
    }
#endregion
}
 ```

### 4.抽象工厂

- 提供一个接口，让该接口负责创建一系列“相关或者相互依赖的对象”，无需指定它们具体的类。
- 抽象工厂模式的主要优点是隔离了具体类的生成，使得客户不需要知道什么被创建了。由于这种隔离，更换一个具体工厂就变得相对容易。所有的具体工厂都实现了抽象工厂中定义的那些公共接口，因此只需改变具体工厂的实例，就可以在某种程度上改变这个软件的系统的行为。另外，应用抽象工厂模式符合GRASP纯虚构的模式，可以实现高内聚低耦合的设计目的，因此抽象工厂模式得到了广泛应用。

 ```
    public class Program
    {
        public static void Main(string[] args)
        {
            Shoes shoes = null;
            Hats hats = null;
            Shop shop = null;

            shop = new NikeShop();
            hats= shop.SellHats();
            shoes= shop.SellShoes();
            Console.WriteLine($"{hats} {shoes}");
        }

    }

    /// <summary>
    /// 鞋系列类
    /// </summary>
    public abstract class Shoes
    {
    }

    /// <summary>
    /// 帽子系列类
    /// </summary>
    public abstract class Hats
    {
    }

    /// <summary>
    /// 商店工厂类
    /// </summary>
    public abstract class Shop
    {
        public abstract Shoes SellShoes();
        public abstract Hats SellHats();
    }

    /// <summary>
    /// Nike系列鞋子
    /// </summary>
    public class NikeShoes : Shoes
    {
        public override string ToString()
        {
            return "Nike系列鞋子";
        }
    }

    /// <summary>
    /// Nike系列帽子
    /// </summary>
    public class NikeHats : Hats
    {
        public override string ToString()
        {
            return "Nike系列帽子";
        }

    }

    /// <summary>
    /// Lining系列鞋子
    /// </summary>
    public class LiningShoes : Shoes
    {
        public override string ToString()
        {
            return "Lining系列鞋子";
        }
    }

    /// <summary>
    /// Lining系列帽子
    /// </summary>
    public class LiningHats : Hats
    {
        public override string ToString()
        {
            return "Lining系列帽子";
        }
    }

    /// <summary>
    ///Nike商店
    /// </summary>
    public class NikeShop : Shop
    {
        public override Hats SellHats()
        {
            return new NikeHats();
        }

        public override Shoes SellShoes()
        {
            return new NikeShoes();
        }
    }

    /// <summary>
    ///Lining商店
    /// </summary>
    public class LiningShop : Shop
    {
        public override Hats SellHats()
        {
            return new LiningHats();
        }

        public override Shoes SellShoes()
        {
            return new LiningShoes();
        }
    }
 ```

### 5.原型模式

- 使用原型实例指定创建对象的种类，然后通过拷贝这些原型来创建新的对象。
- 原型模式得到了广泛的应用，特别是在创建对象成本较大的情况下(初始化需占用较长时间，占用太多CPU资源或网络资源。比如通过Webservice或DCOM创建对象，或者创建对象要装载大文件)，系统如果需要重复利用，新的对象可以通过原型模式对已有对象的属性进行复制并稍作修改来取得。另外，如果系统要保存对象的状态而对象的状态变化很小，或者对象本身占内存不大的时候，也可以用原型模式配合备忘录模式来应用。相反地，如果对象的状态变化很大，或者对象占用内存很大，那么采用状态模式会比原型模式更好。原型模式的缺点是在实现深层复制时需要编写复杂的代码。

 ```
    public class Program
    {
        public static void Main(string[] args)
        {
            Build buildA = new Build();
            buildA.Number = 9;
            buildA.Location = "天津路";
            buildA.Developer = new Developers() { DeveloperName = "恒大" };
            Build buildB = (Build)(buildA as ICloneable).Clone();
            buildB.Developer = new Developers() { DeveloperName = "华邦" };
        }

    }

    public class Build : ICloneable
    {
        /// <summary>
        /// 门牌号
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 开发商信息
        /// </summary>
        public Developers Developer { get; set; }

        /// <summary>
        /// 克隆本身，返回新对象
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //Build build = new Build();
            //build.Number = this.Number + 1;
            //build.Location = this.Location;
            //return build;
            Build newInstance = (Build)base.MemberwiseClone();
            newInstance.Developer =(Developers)(newInstance.Developer as ICloneable).Clone();
            return newInstance;
        }
    }

    /// <summary>
    /// 开发商信息
    /// </summary>
    public class Developers : ICloneable
    {
		//MemberwiseClone 浅拷贝
        public string DeveloperName { get; set; }
        public object Clone()
        {
            return base.MemberwiseClone();
        }
    }
 ```

### 6.适配器模式

- 将一个类的接口转换成客户希望的另一个接口。 适配器模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
- 适配器模式可以将一个类的接口和另一个类的接口匹配起来，使用的前提是你不能或不想修改原来的适配器母接口(adapter)。例如，你向第三方购买了一些类、控件，但是没有源程序，这时，使用适配器模式，你可以统一对象访问接口。但客户调用可能需要变动。

 ```
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player1 = new USAPlayer() { Name = "Joken" };
            Player player2 = new Translator() { Name = "姚明" };
            player1.Attack();
            player2.Defense();
        }

    }

    /// <summary>
    /// 运动员类
    /// </summary>
    public abstract class Player
    {
        public string Name { get; set; }

        public abstract void Attack();

        public abstract void Defense();
    }

    /// <summary>
    /// 美国球员
    /// </summary>
    public class USAPlayer : Player
    {
        /// <summary>
        /// 美国队员进攻
        /// </summary>
        public override void Attack()
        {
            Console.WriteLine($"{base.Name}:Attack");
        }

        /// <summary>
        /// 美国队员防守
        /// </summary>
        public override void Defense()
        {
            Console.WriteLine($"{base.Name}:Defense");
        }
    }

    public class Translator : Player
    {
        static string name = "";
        public Translator() : base()
        {
            name = Name;
        }
        CBAPlayer player = new CBAPlayer() { Name = name };

        /// <summary>
        /// 适配转换进攻命令
        /// </summary>
        public override void Attack()
        {
            player.CBA_Attack() ;
        }

        /// <summary>
        /// 适配转换防守命令
        /// </summary>
        public override void Defense()
        {
            player.CBA_Defense();
        }
    }

    /// <summary>
    /// 中国球员
    /// </summary>
    public class CBAPlayer
    {
        public string Name { get; set; }

        /// <summary>
        /// 中国球员进攻
        /// </summary>
        public void CBA_Attack()
        {
            Console.WriteLine($"{Name}:Attack");
        }

        /// <summary>
        /// 中国球员防守
        /// </summary>
        public void CBA_Defense()
        {
            Console.WriteLine($"{Name}:Defense");
        }
    }
 ```

### 7.桥接模式

- 将抽象部分与实现部分分离，使它们都可以独立地变化。
- 桥接模式可以从接口中分离实现功能，使得设计更具扩展性，这样，客户调用方法时根本不需要知道实现的细节。
  桥接模式减少了子类，假设程序要在2个操作系统中处理6种图像格式，纯粹的继承就需要(2*6)12个子类，而应用桥接模式，只需要(2+6)8个子类。它使得代码更清洁，生成的执行程序文件更小。　　
  桥接模式的缺陷是抽象类与实现类的双向连接使得运行速度减慢

 ```
   public class Program
    {
        public static void Main(string[] args)
        {
            Phones phone1 = new Samsung();
            Phones phone2 = new Xiaomi();
            phone1.InstallAPP(new Meituan());
            phone1.InstallAPP(new Mito());

            phone2.InstallAPP(new Meituan());
            phone2.InstallAPP(new Mito());
            phone2.InstallAPP(new Alipay());

            phone1.APP_Run();
            phone2.APP_Run();
        }

    }

    /// <summary>
    /// 手机
    /// </summary>
    public abstract class Phones
    {
        /// <summary>
        /// 软件集合
        /// </summary>
        private List<Softwares> list = new List<Softwares>();
        /// <summary>
        /// 手机品牌
        /// </summary>
        public abstract string PhoneBrands { get; }

        /// <summary>
        /// 安装软件
        /// </summary>
        /// <param name="software"></param>
        public void InstallAPP(Softwares software)
        {
            list.Add(software);
        }

        /// <summary>
        /// 运行所有安装的软件
        /// </summary>
        public void APP_Run()
        {
            Console.WriteLine($"{PhoneBrands}开始运行安装的软件");
            foreach (var item in list)
            {
                item.Run();
            }
            Console.WriteLine($"{PhoneBrands}运行所有软件完\r\n");
        }
    }

    /// <summary>
    /// 功能软件
    /// </summary>
    public abstract class Softwares
    {
        /// <summary>
        /// 软件名称
        /// </summary>
        public abstract string APPName { get; }
        /// <summary>
        /// 运行软件
        /// </summary>
        public virtual void Run()
        {
            Console.WriteLine($"软件：{APPName} 开始运行！");
        }
    }

    /// <summary>
    /// 三星手机
    /// </summary>
    public class Samsung : Phones
    {
        public override string PhoneBrands => "Samsung";
    }

    /// <summary>
    /// 小米手机
    /// </summary>
    public class Xiaomi : Phones
    {
        public override string PhoneBrands => "小米";
    }


    /// <summary>
    /// 美团软件
    /// </summary>
    public class Meituan : Softwares
    {
        public override string APPName => "美团";
    }

    /// <summary>
    /// 支付宝软件
    /// </summary>
    public class Alipay : Softwares
    {
        public override string APPName => "支付宝";
    }

    /// <summary>
    /// 美图软件
    /// </summary>
    public class Mito : Softwares
    {
        public override string APPName => "美图";
    }
 ```

### 8.组合模式

- 将对象组合成树形结构以表示“部分-整体”的层次结构。组合模式使得用户对单个对象和组合对象的使用具有一致性。
- 组合模式可以清楚地定义分层次的复杂对象，表示对象的全部或部分层次，使得增加新部件也更容易，因为它让客户忽略了层次的不同性，而它的结构又是动态的，提供了对象管理的灵活接口。组合模式对于树结构的控制有着神奇的功效，例如在人力资源系统的组织架构及ERP系统的BOM设计中，组合模式得到重点应用。
  组合模式的缺陷是使得设计变得更加抽象。对象的商业规则如果很复杂，则实现组合模式具有很大挑战性，并且，不是所有的方法都与叶部件子类有关联。

 ```
        public static void Main(string[] args)
        {
            Component computer = new Composite() { Name="电脑"};

            Component box = new Composite() { Name = "机箱", Price = 300 };
            Component video = new Composite() { Name = "显示器", Price = 1500 };

            Component motherboard = new Composite() { Name = "主板", Price = 1000 };
            Component harddisk = new Leaf() { Name = "硬盘", Price = 600 };
           
            Component cpu = new Leaf() { Name = "CPU", Price = 1000 };
            Component videocard = new Leaf() { Name = "显卡", Price = 1200 };
            Component memory = new Leaf() { Name = "内存", Price = 500 };

            motherboard.Add(cpu);
            motherboard.Add(videocard);
            motherboard.Add(memory);

            box.Add(motherboard);
            box.Add(harddisk);

            computer.Add(box);
            computer.Add(video);

            int totalPrice = computer.TotalPrice();
            Console.WriteLine($"{computer.Name}的总价是：{totalPrice}");
        }

        /// <summary>
        /// 组件类
        /// </summary>
        public abstract class Component
        {
            /// <summary>
            /// 当前组件的单价
            /// </summary>
            /// <returns></returns>
            public int Price { get; set; }
            /// <summary>
            /// 当前组件的名称
            /// </summary>
            /// <returns></returns>
            public string Name { get; set; }

            /// <summary>
            /// 向当前组件添加组件
            /// </summary>
            /// <returns></returns>
            public abstract void Add(Component part);

            /// <summary>
            /// 从当前组件移除组件
            /// </summary>
            /// <returns></returns>
            public abstract void Remove(Component part);
            /// <summary>
            /// 当前组件的总价
            /// </summary>
            /// <returns></returns>
            public abstract int TotalPrice();
        }

        /// <summary>
        /// 单一组件，不包含任何组件
        /// </summary>
        public class Leaf : Component
        {
            public override void Add(Component part)
            {
                throw new InvalidOperationException("当前组件不允许有节点");
            }

            public override void Remove(Component part)
            {
                throw new InvalidOperationException("当前组件不允许有节点");
            }

            public override int TotalPrice()
            {
                return base.Price;
            }
        }

        /// <summary>
        /// 组件内部包含其他组件
        /// </summary>
        public class Composite : Component
        {
            /// <summary>
            /// 组件容器集合
            /// </summary>
            private List<Component> list = new List<Component>();
            /// <summary>
            /// 添加组件
            /// </summary>
            public override void Add(Component part)
            {
                list.Add(part);
            }

            /// <summary>
            /// 删除组件
            /// </summary>
            public override void Remove(Component part)
            {
                list.Remove(part);
            }

            /// <summary>
            /// 计算组件总价
            /// </summary>
            public override int TotalPrice()
            {
                int totalPrice=Price;
                foreach (var item in list)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            }
        } 
 ```

### 9.装饰模式

- 动态地给一个对象增加一些额外的职责。就增加功能而言，装饰模式比生产子类更灵活。
- 装饰模式提供了比静态继承更好的柔韧性，它允许开发一系列的功能类用来代替增加对象的行为，这既不会污染原来对象的源码，还能使代码更容易编写，使类更具扩展性，因为变化都是由新的装饰类来完成。还可以建立连接的装饰对象关系链。
  需要注意的是，装饰链不宜过长。装饰链太长会使系统花费较长时间用于初始化对象，同时信息在链中的传递也会浪费太多的时间。这个情况好比物品包装，包了一层又一层，大包套小包。另外，如果原来的对象接口发生变化，它所有的装饰类都要修改以匹配它的变化。派生子类会影响对象的内部，而一个Decorator只会影响对象的外表。

```
        public static void Main(string[] args)
        {
            IDecoratabler camera = new Camera500();

            Decorator tripod = new Tripod();
            Decorator lens = new Lens();
            Decorator flash = new Flash();

            tripod.ToDecorator = lens;
            lens.ToDecorator = flash;
            flash.ToDecorator = camera;

            tripod.Decorate();
        }

        /// <summary>
        /// 可以动态添加新功能的接口
        /// </summary>
        public interface IDecoratabler
        {
            /// <summary>
            /// 添加新功能并运行
            /// </summary>
            void Decorate();
        }

        /// <summary>
        /// 相机
        /// </summary>
        public abstract class Camera : IDecoratabler
        {
            /// <summary>
            /// 拍照功能
            /// </summary>
            public abstract void TakePhotos();

            /// <summary>
            /// 实现接口中定义的功能
            /// </summary>
            public void Decorate()
            {
                //转换为自身功能
                TakePhotos();
            }
        }

        /// <summary>
        /// 500相机
        /// </summary>
        public class Camera500 : Camera
        {
            public override void TakePhotos()
            {
                Console.WriteLine("500D拍照");
            }
        }

        public abstract class Decorator : IDecoratabler
        {
            /// <summary>
            /// 要被依附的对象
            /// </summary>
            public IDecoratabler ToDecorator { get; set; }

            /// <summary>
            /// 运行要执行的行为
            /// </summary>
            public virtual void Decorate()
            {
                if (ToDecorator != null)
                {
                    ToDecorator.Decorate();
                }
            }
        }

        /// <summary>
        /// 固定三脚架
        /// </summary>
        public class Tripod : Decorator
        {
            public override void Decorate()
            {
                Console.WriteLine("安装三脚架并固定相机");
                base.Decorate();
            }
        }

        /// <summary>
        /// 安装镜头
        /// </summary>
        public class Lens : Decorator
        {
            public override void Decorate()
            {
                Console.WriteLine("安装镜头并调整焦距");
                base.Decorate();
            }
        }

        /// <summary>
        /// 打开闪光灯
        /// </summary>
        public class Flash : Decorator
        {
            public override void Decorate()
            {
                Console.WriteLine("闪光灯通电闪光");
                base.Decorate();
            }
        }
```

### 10.外观模式

- 为子系统中的一组接口提供一个一致的界面，外观模式定义了一个高层接口，这个接口使得这一子系统更加容易使用。
- 外观模式提供了一个简单且公用的接口去处理复杂的子系统，并且没有减少子系统的功能。它遮蔽了子系统的复杂性，避免了客户与子系统直接链接，它也减少了子系统与子系统间的连接，每个子系统都有它的外观模式，每个子系统采用外观模式去访问其他子系统。外观模式的劣势就是限制了客户的自由，减少了可变性。

```
    static void Main(string[] args)
     {
         Facade facade = new Facade();
         facade.MethodA();
         facade.MethodB();
     }

    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法一");
        }
    }
    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法二");
        }
    }
    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("子系统方法三");
        }
    }
    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("子系统方法四");
        }
    }
    class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }
        public void MethodA()
        {
            Console.WriteLine("\n方法组合A()---");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }
        public void MethodB()
        {
            Console.WriteLine("\n方法组B()---");
            two.MethodTwo();
            three.MethodThree();
        }
    }
```

### 11.享元模式

- 运用共享技术有效地支持大量细粒度的对象。
- 享元模式需要你认真考虑如何能细化对象，以减少处理的对象数量，从而减少存留对象在内存或其他存储设备中的占用量。然而，此模式需要维护大量对象的外部状态，如果外部状态的数据量大，传递、查找、计算这些数据会变得非常复杂。当外部和内部的状态很难分清时，不宜采用享元模式。

```
    static void Main(string[] args)
    {
        School school = new School();
        Student student = school.GetStudent(1);
        Console.WriteLine(student.ToString());
        student = school.GetStudent(2);
        Console.WriteLine(student.ToString());
        Console.ReadKey();
    }


    public abstract class abStudent
    {
        public string Name;
        public string schName;
        public string Sex;
        public abStudent()
        {
            schName = "西南科技大学";
            Sex = "男";
        }
 
        public override string ToString()
        {
            return string.Format("我叫{0},性别{1},在读学校{2}", Name, Sex, schName);
        }
    }
    public class Student : abStudent
    {
        public Student(string name)
        {
            Name = name;
        }
    }
    public class School
    {
        private Dictionary<int, Student> StudentList;
        public School()
        {
            StudentList = new Dictionary<int, Student>();
            StudentList.Add(1, new Student("张三"));
            StudentList.Add(2, new Student("李四"));
        }
        public Student GetStudent(int num)
        {
            return StudentList[num] as Student;
        }
    }
```

### 12.代理模式

- 为其它对象提供一种代理以控制对这个对象的范围。
- 当对象在远程机器上，要通过网络来生成时，速度可能会慢，此时应用Remote Proxy模式，可以掩蔽对象由网络生成的过程，系统的速度会加快；对于大图片的加载，Virtual Proxy模式可以让加载在后台进行，前台用的Proxy对象使得整体运行速度得到优化；Protect Proxy可以验证对真实对象的引用权限。
  代理模式的缺陷是请求的处理速度会变慢，并且实现Proxy模式需要额外的工作。

```
       /// <summary>
       /// 代理模式和适配器模式区别：代理模式下，需要代理的类和代理类有统一接口，适配器模式下，适配的对象没有和适配器实现同一接口
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            IGirlFired girlFired = new Classmate();
            girlFired.WatchFilm();

            girlFired = new Diamond();
            girlFired.WatchFilm();
        }

        /// <summary>
        /// 接口
        /// </summary>
        public interface IGirlFired
        {
            /// <summary>
            /// 看电影
            /// </summary>
            void WatchFilm();
        }

        /// <summary>
        /// 校花
        /// </summary>
        public class SchoolFlower : IGirlFired
        {
            public void WatchFilm()
            {
                Console.WriteLine("校花陪同看电影");
            }
        }

        /// <summary>
        /// 校花室友
        /// </summary>
        public class Classmate : IGirlFired
        {
            private SchoolFlower schoolFlower = new SchoolFlower();
            public void WatchFilm()
            {
                Console.WriteLine("室友铺垫"); 

                Console.WriteLine("室友邀请");

                schoolFlower.WatchFilm();

                Console.WriteLine("室友任务完成");
            }
        }

        /// <summary>
        /// 钻石代理
        /// </summary>
        public class Diamond : IGirlFired
        {
            private SchoolFlower schoolFlower = new SchoolFlower();

            public void WatchFilm()
            {
                Console.WriteLine("掏出鸽子蛋大的钻石");
                schoolFlower.WatchFilm();
                Console.WriteLine("校花随便干啥");

            }
        }
```

### 13.模板方法

- 定义一个操作中算法的骨架，而将一些步骤延迟到子类中。模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
- 模版方法模式在一个类中形式化地定义算法，而由它的子类实现细节的处理。模版方法模式的优势是，在子类定义处理算法时不会改变算法的结构。
  模版方法的特点在于，每个不同的实现都需要定义一个子类，这也复合高内聚的责任分配模式，不能说成是它的缺点。

```
       public static void Main(string[] args)
        {
            Vegetabel spinach = new Spinach();
            spinach.CookVegetabel();
            spinach = new ChineseCabbage();
            spinach.CookVegetabel();

            Console.Read();
        }

        /// <summary>
        /// 炒蔬菜
        /// </summary>
        public abstract class Vegetabel
        {
            // 模板方法，不要把模版方法定义为Virtual或abstract方法，避免被子类重写，防止更改流程的执行顺序
            public void CookVegetabel()
            {
                Console.WriteLine("抄蔬菜的一般做法");
                pourOil();
                HeatOil();
                pourVegetable();
                stir_fry();
            }
            protected void pourOil()
            {
                Console.WriteLine("倒油");
            }
            protected void HeatOil()
            {
                Console.WriteLine("把油烧热");
            }
            protected abstract void pourVegetable();// 油热了之后倒蔬菜下去，具体哪种蔬菜由子类决定
            protected void stir_fry()
            {
                Console.WriteLine("翻炒");
            }
        }

        /// <summary>
        /// 炒菠菜
        /// </summary>
        public class Spinach : Vegetabel// 菠菜
        {

            protected override void pourVegetable()
            {
                Console.WriteLine("倒菠菜进锅中");
            }
        }

        /// <summary>
        /// 炒大白菜
        /// </summary>
        public class ChineseCabbage : Vegetabel// 大白菜
        {
            protected override void pourVegetable()
            {
                Console.WriteLine("倒大白菜进锅中");
            }
        }
```

### 14.命令模式

- 将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；对请求排队并记录请求日志，以及支持可撤销的操作。
- 命令模式分离了接受请求的对象与实现处理请求工作的对象，这样，已经存在的类可以保持不变，使得增加新类的工作更简单。例如，很多软件的宏命令就提高了系统的自动化程度。
  命令模式还可以分离用户界面和业务对象，降低系统的耦合度。
  但是，命令模式最主要的缺陷就是，类的数量增加了，系统变得更复杂，程序的调试工作也相应变得困难。

```
        public static void Main(string[] args)
        {
            OrderCommand order1 = new OrderCommand() { Customer = "张三", Total = 100 };
            OrderCommand order2 = new OrderCommand() { Customer = "李四", Total = 500 };
            OrderCommand order3 = new OrderCommand() { Customer = "王五", Total = 800 };

            Invoker invoker = new Invoker();
            invoker.AddCommand(order1);
            invoker.AddCommand(order2);
            invoker.AddCommand(order3);

            invoker.RemoveCommand(order1);

            Network.Online = false;
            invoker.ExcuteCommands();

            Network.Online = true;
            invoker.ExcuteCommands();
        }

        /// <summary>
        /// 网络是否通畅
        /// </summary>
        public class Network
        {
            public static bool Online = true;
        }

        /// <summary>
        /// Receiveer 命令执行者（接收者）
        /// </summary>
        public class Webservice
        {
            /// <summary>
            /// 下单
            /// </summary>
            /// <param name="orderNo">订单号</param>
            /// <param name="total">订单数量</param>
            /// <param name="customer">下单人员</param>
            public void NewOrder(Guid orderNo, int total, string customer)
            {
                Console.WriteLine($"{customer}在{DateTime.Now}下单，订单号为：{orderNo},数量为：{total}");
            }
        }

        /// <summary>
        /// 命令的抽象
        /// </summary>
        public abstract class Command
        {
            /// <summary>
            /// 执行的命令
            /// </summary>
            public abstract void Excute();

            /// <summary>
            /// 命令ID
            /// </summary>
            public abstract Guid CommandID { get; }

        }

        /// <summary>
        /// 具体命令
        /// </summary>
        public class OrderCommand : Command
        {
            private Webservice webservice = new Webservice();
            private Guid guid;

            public OrderCommand()
            {
                guid = Guid.NewGuid();
            }
            public override Guid CommandID => guid;

            public override void Excute()
            {
                webservice.NewOrder(guid, Total, Customer);
            }

            public int Total { get; set; }

            public string Customer { get; set; }

            public Guid GetOrderNo
            {
                get
                {
                    return guid;
                }
            }
        }

        /// <summary>
        /// 调度者
        /// </summary>
        public class Invoker
        {
            /// <summary>
            /// 命令字典
            /// </summary>
            private Dictionary<Guid, Command> DictCommands = new Dictionary<Guid, Command>();

            /// <summary>
            /// 添加命令
            /// </summary>
            /// <param name="command"></param>
            public void AddCommand(Command command)
            {
                if (!DictCommands.ContainsKey(command.CommandID))
                {
                    DictCommands.Add(command.CommandID, command);
                }
                else
                {
                    Console.WriteLine($"命令ID:{command.CommandID}已存在!");
                }
            }

            /// <summary>
            /// 移除命令
            /// </summary>
            /// <param name="command"></param>
            public void RemoveCommand(Command command)
            {
                if (DictCommands.ContainsKey(command.CommandID))
                {
                    DictCommands.Remove(command.CommandID);
                }
                else
                {
                    Console.WriteLine($"命令ID:{command.CommandID}不存在!");
                }
            }

            /// <summary>
            /// 执行任务队列
            /// </summary>
            public void ExcuteCommands()
            {
                if (Network.Online)
                {
                    foreach (var item in DictCommands)
                    {
                        item.Value.Excute();
                    }
                }
                else
                {
                    Console.WriteLine("网络连接短开，暂时无法下单，订单已缓存！");
                }
            }
        }
```

### 15.解释器模式

- 给定一个语言，定义它的文法的一种表示，并定义一种解释器，这个解释器使用该表示来解释语言中的句子。
- 解释器模式的作用很强大，它使得改变和扩展文法变得容易，实现文法也变得简单明了，很多编译器，包括文本编辑器、网页浏览器及VRML都应用解释器模式。
  解释器模式的缺陷就是，因为文句会分析成树结构，解释器需要递归访问它，所以效率会受影响。这种情况开发人员会有所体会，编译整个工程源码耗费时间都比较长。

```
     static void Main(string[] args)
     {
         BooleanExp booleanExp1 = new BooleanExp("true");
         BooleanExp booleanExp2 = new BooleanExp("false");
 
         OrExp orExp = new OrExp(booleanExp1, booleanExp2);//或表达式
         Console.WriteLine(orExp.Interpret());
 
         AndExp andExp = new AndExp(booleanExp1, booleanExp2);//与表达式
         Console.WriteLine(andExp.Interpret());
 
         Console.Read();
     }


    abstract class ExpressionClass
    {
        public abstract bool Interpret();
    }
    class BooleanExp : ExpressionClass//布尔表达式
    {
        string Context;
        public BooleanExp(string context)
        {
            Context = context;
        }
        public override bool Interpret()
        {
            return Context.ToLower() == "true";
        }
    }
    class OrExp : ExpressionClass//或表达式
    {
        BooleanExp Exp1;
        BooleanExp Exp2;
 
        public OrExp(BooleanExp exp1, BooleanExp exp2)
        {
            Exp1 = exp1;
            Exp2 = exp2;
        }
        public override bool Interpret()
        {
            return Exp1.Interpret() || Exp2.Interpret();
        }
    }
    class AndExp : ExpressionClass// 与表达式
    {
        BooleanExp Exp1;
        BooleanExp Exp2;
        public AndExp(BooleanExp exp1, BooleanExp exp2)
        {
            Exp1 = exp1;
            Exp2 = exp2;
        }
        public override bool Interpret()
        {
            return Exp1.Interpret() && Exp2.Interpret();
        }
    }
```

### 16.中介者模式

- 用一个中介对象来封装一系列的对象交互。中介者使用对象不需要显式的相互作用，从而使其耦合松散，而且可以可以独立改变他们之间的内部交互（多对多）
- 中介者模式分离了两个同事类，简化了对象协议，中央控制对象交互，从而使个体对象变得更容易且更简单，因为它不需要传递数据给其他个体对象，仅仅传给中介者就可以了。个体对象不需要具有处理内部交流的逻辑，所以更加突出它的面向对象特性。

```
       static void Main(string[] args)
        {
            SupperMarket mediator = new SupperMarket();
            Colleague customer1 = new Coustom(mediator, "客户1");
            Colleague customer2 = new Coustom(mediator, "客户2");
            Colleague supplier = new Supplier(mediator,"供应商1");

            mediator.Promot();
            //supplier.PublishNotice("大促销，买一送一",supplier);

            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 参与交互的类
        /// </summary>
        public abstract class Colleague
        {
            /// <summary>
            /// 名称
            /// </summary>
            protected string _name;

            /// <summary>
            /// 构造函数，初始化参数
            /// </summary>
            /// <param name="mediator"></param>
            /// <param name="Name"></param>
            public Colleague(Mediator mediator,string Name)
            {
                _name = Name;
                TheMediator = mediator;
                mediator.Register(this);
            }
            /// <summary>
            /// 中介者
            /// </summary>
            public Mediator TheMediator { get; set; }

            /// <summary>
            /// 收到中介者的公告信息
            /// </summary>
            /// <param name="notice"></param>
            public abstract void ReceiveNotice(string notice);

            /// <summary>
            /// 向中介者发布消息
            /// </summary>
            /// <param name="notice"></param>
            public virtual void  (string notice, Colleague colleague)
            {
                TheMediator.Bulletin(notice,colleague);
            }
        }

        /// <summary>
        /// 中介者
        /// </summary>
        public abstract class Mediator
        {
            /// <summary>
            /// 同事集合
            /// </summary>
            protected List<Colleague> colleagues = new List<Colleague>();

            /// <summary>
            /// 注册同事
            /// </summary>
            /// <param name="colleague"></param>
            public void Register(Colleague colleague)
            {
                colleagues.Add(colleague);
            }

            /// <summary>
            /// 移除同事
            /// </summary>
            /// <param name="colleague"></param>
            public void Remove(Colleague colleague)
            {
                colleagues.Remove(colleague);
            }

            /// <summary>
            /// 向每个同事发布公告
            /// </summary>
            /// <param name="content"></param>
            public virtual void Bulletin(string content,Colleague colleague)
            {
                foreach (var item in colleagues)
                {
                    if (colleague!= item)
                    {
                        item.ReceiveNotice(content);
                    }
                }
            }
        }

        public class SupperMarket:Mediator
        {
            /// <summary>
            /// 发布公告
            /// </summary>
            /// <param name="content"></param>
            public override void Bulletin(string content,Colleague colleague)
            {
                Console.WriteLine($"超市发布新公告:{content}");
                base.Bulletin(content, colleague);

            }

            /// <summary>
            /// 公告发布
            /// </summary>
            /// <param name="content"></param>
            public void Promot()
            {
                this.Bulletin("中秋大促销", null);
            }
        }

        /// <summary>
        /// 客户收到通知
        /// </summary>
        public class Coustom : Colleague
        {
            /// <summary>
            /// 构造函数初始化
            /// </summary>
            /// <param name="mediator"></param>
            /// <param name="Name"></param>
            public Coustom(Mediator mediator, string Name) : base(mediator, Name)
            { 
            }
            public override void ReceiveNotice(string notice)
            {
                Console.WriteLine($"顾客:{_name}收到通知：{notice}") ;
            }
        }

        /// <summary>
        /// 供应商加大库存
        /// </summary>
        public class Supplier : Colleague
        {

            /// <summary>
            /// 构造函数初始化
            /// </summary>
            /// <param name="mediator"></param>
            /// <param name="Name"></param>
            public Supplier(Mediator mediator, string Name) : base(mediator, Name)
            {
            }
            public override void ReceiveNotice(string notice)
            {
                Console.WriteLine($"供应商:{_name}收到通知：{notice}");
                Console.WriteLine($"供应商:{_name}增加库存");
            }
        }
```

### 17.迭代器模式

- 提供一种方法顺序访问一个聚合对象中的各个元素，而又不暴露该对象的内部表示。

```
        static void Main(string[] args)
        {
            Classes<Student> classes = new Classes<Student>();

            Student student1 = new Student("张三");
            Student student2 = new Student("李四");
            Student student3 = new Student("王五");

            Iterator<Student> iterator = (classes as Aggregate<Student>).CreateIterator();
            classes.AddStudent(student1);
            classes.AddStudent(student2);
            classes.AddStudent(student3);

            while (!iterator.Done)
            {
                Student student = iterator.Current();
                Console.WriteLine(student);
                iterator.Next();
            }


            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 聚合对象(集合)
        /// </summary>
        public abstract class Aggregate<T>
        {
            /// <summary>
            /// 创建迭代器
            /// </summary>
            /// <returns></returns>
            public abstract Iterator<T> CreateIterator();

        }


        /// <summary>
        /// 迭代器:遍历内部集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract class Iterator<T>
        {
            /// <summary>
            /// 返回集合第一个
            /// </summary>
            /// <returns></returns>
            public abstract T First();

            /// <summary>
            /// 遍历下个元素
            /// </summary>
            /// <returns></returns>
            public abstract void Next();


            /// <summary>
            /// 返回集合当前元素
            /// </summary>
            /// <returns></returns>
            public abstract T Current();


            /// <summary>
            /// 集合是否遍历完成
            /// </summary>
            /// <returns></returns>
            public abstract bool Done { get; }
        }

        /// <summary>
        /// 班级类
        /// </summary>
        public class Classes<T> : Aggregate<T>
        {
            /// <summary>
            /// 学生集合
            /// </summary>
            private List<T> students = new List<T>();

            /// <summary>
            /// 集合中添加学生
            /// </summary>
            /// <param name="student"></param>
            public void AddStudent(T student)
            {
                students.Add(student);
            }

            public override Iterator<T> CreateIterator()
            {
                return new ClassIterator<T>(this);
            }

            /// <summary>
            /// 获取当前集合的总数
            /// </summary>
            public int GetCounts { get { return students.Count; } }

            /// <summary>
            /// 返回当前索引的学生对象
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public T this[int index]
            {
                get { return students[index]; }
            }

        }

        /// <summary>
        /// 班级类迭代器
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class ClassIterator<T> : Iterator<T>
        {
            /// <summary>
            /// 班级类
            /// </summary>
            private Classes<T> _classes = null;

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="classes"></param>
            public ClassIterator(Classes<T> classes)
            {
                _classes = classes;
            }

            private int _currentindex = 0;

            public override bool Done  {get{ return _currentindex == _classes.GetCounts; } }

            public override T Current()
            {
                return _classes[_currentindex];
            }

            public override T First()
            {
                return _classes[0];
            }

            public override void Next()
            {
                _currentindex++;
            }
        }



        /// <summary>
        /// 学生类
        /// </summary>
        public class Student
        {
            /// <summary>
            /// 学生姓名
            /// </summary>
            private string _name;

            /// <summary>
            /// 构造函数初始化
            /// </summary>
            /// <param name="Name"></param>
            public Student(string Name)
            {
                _name = Name;
            }

            public override string ToString()
            {
                return $"学生姓名：{_name}";
            }
        }
```

```
       static void Main(string[] args)
        {
            Classes<Student> classes = new Classes<Student>();

            Student student1 = new Student("张三");
            Student student2 = new Student("李四");
            Student student3 = new Student("王五");

            System.Collections.Generic.IEnumerator<Student> iterator = (classes as System.Collections.Generic.IEnumerable<Student>).GetEnumerator();
            classes.AddStudent(student1);
            classes.AddStudent(student2);
            classes.AddStudent(student3);

            while (iterator.MoveNext())
            {
                Student student = iterator.Current;
                Console.WriteLine(student);
            }


            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// 班级类
        /// </summary>
        public class Classes<T> : System.Collections.Generic.IEnumerable<T>
        {
            /// <summary>
            /// 学生集合
            /// </summary>
            private List<T> students = new List<T>();

            /// <summary>
            /// 集合中添加学生
            /// </summary>
            /// <param name="student"></param>
            public void AddStudent(T student)
            {
                students.Add(student);
            }

            //public IEnumerator<T> GetEnumerator()
            //{
            //    foreach (var student in students)
            //    {
            //        yield return student;
            //    };
            //}

            public IEnumerator<T> GetEnumerator()
            {
                return new ClassIterator<T>(this);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new ClassIterator<T>(this);
            }

            /// <summary>
            /// 获取当前集合的总数
            /// </summary>
            public int GetCounts { get { return students.Count; } }

            /// <summary>
            /// 返回当前索引的学生对象
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public T this[int index]
            {
                get { return students[index]; }
            }

        }

        /// <summary>
        /// 班级类迭代器
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class ClassIterator<T> : System.Collections.Generic.IEnumerator<T>
        {
            /// <summary>
            /// 班级类
            /// </summary>
            private Classes<T> _classes = null;

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="classes"></param>
            public ClassIterator(Classes<T> classes)
            {
                _classes = classes;
            }

            private int _currentindex =-1;


            T IEnumerator<T>.Current
            {
                get { return  this._classes[_currentindex]; }
            }

            public object Current
            {
                get { return this._classes[_currentindex]; }
            }

            public bool MoveNext()
            {
                _currentindex++;
                return _currentindex != this._classes.GetCounts;
            }

            public void Reset()
            {
                _currentindex=-1;
            }

            public void Dispose()
            {
                this.Dispose();
            }
        }



        /// <summary>
        /// 学生类
        /// </summary>
        public class Student
        {
            /// <summary>
            /// 学生姓名
            /// </summary>
            private string _name;

            /// <summary>
            /// 构造函数初始化
            /// </summary>
            /// <param name="Name"></param>
            public Student(string Name)
            {
                _name = Name;
            }

            public override string ToString()
            {
                return $"学生姓名：{_name}";
            }
        }
```

### 18.职责链模式

- 使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系。将这些对象连成一条链，并沿着这条链传递请求，直到有一个对象处理它为止。
- 责任链模式可以减少对象的连接，为对象责任分配增加了很大的灵活性。该模式允许把一组类作为一个类来使用，并且在类的组合中，一个类的事件可以发送到另一个类并由其处理。
  责任链模式通常应用与图形用户界面中，窗体的部件可能会包含其他几个小部件，就如同Windows窗体应用程序中，控件中又可以放置其他控件，控件边界会决定是否处理事件，或者将事件传递给父控件来处理。
  另外，责任链还会以树状出现，这样，一个事件可以传给多个类，或者，多个类的信息可以提交到一个类。树状责任链能够提供更灵活的技巧，但缺点是信息在树中容易迷失。

```
 	public class PurchaseRequest// 采购请求
    {
        
        public double Amount { get; set; }// 金额
        public string ProductName { get; set; }
        public PurchaseRequest(double amount, string productName)
        {
            Amount = amount;
            ProductName = productName;
        }
    }
    public abstract class Approver// 审批人,Handler
    {
        public Approver NextApprover { get; set; }
        public string Name { get; set; }
        public Approver(string name)
        {
            Name = name;
        }
        public abstract void ProcessRequest(PurchaseRequest request);
    }
    public class Manager : Approver
    {
        public Manager(string name): base(name) { }
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 10000.0)
            {
                Console.WriteLine("{0}-{1}  想买  {2}", this, Name, request.ProductName);
            }
            else if (NextApprover != null)
            {
                NextApprover.ProcessRequest(request);
            }
        }
    }
    public class VicePresident : Approver// ConcreteHandler,副总
    {
        public VicePresident(string name): base(name) { }
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 25000.0)
            {
                Console.WriteLine("{0}-{1}  想买  {2}", this, Name, request.ProductName);
            }
            else if (NextApprover != null)
            {
                NextApprover.ProcessRequest(request);
            }
        }
    }
    public class President : Approver// ConcreteHandler，总经理
    {
        public President(string name): base(name) { }
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 100000.0)
            {
                Console.WriteLine("{0}-{1}  想买  {2}", this, Name, request.ProductName);
            }
            else
            {
                Console.WriteLine("Request需要组织一个会议讨论");
            }
        }
    }

    static void Main(string[] args)
    {
        PurchaseRequest requestTelphone = new PurchaseRequest(4000.0, "手机");
        PurchaseRequest requestSoftware = new PurchaseRequest(10000.0, "软件");
        PurchaseRequest requestComputers = new PurchaseRequest(40000.0, "电脑");
 
        Approver manager = new Manager("张三");
        Approver Vp = new VicePresident("李四");
        Approver Pre = new President("王五");
    
        manager.NextApprover = Vp;// 设置责任链
        Vp.NextApprover = Pre;
 
        manager.ProcessRequest(requestTelphone); // 处理请求
        manager.ProcessRequest(requestSoftware);
        manager.ProcessRequest(requestComputers);
        Console.ReadLine();
        }

```

### 19.观察者模式

- 定义对象间的一种一对多的依赖关系，以便当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并自动更新。
- 观察者模式抽象了被观察对象与观察者对象的连接，提供了广播式的对象间通信，并且容易增加新的观察者对象。观察者模式的缺陷是对象间的关系难以理解，在某种情况下会表现低效能。

```
        static void Main(string[] args)
        {
            Subject subject = new Criminal();
            Observe police = new Police(subject);
            Observe citizen = new Citizen(subject);

            Criminal criminal = subject as Criminal;
            criminal.RunAway("广西");
            Console.WriteLine("");
            criminal.Detach(police);
            criminal.RunAway("美国");

            Console.WriteLine("");
        }

        /// <summary>
        /// 关注的目标
        /// </summary>
        public abstract class Subject
        {
            /// <summary>
            /// 关注对象集合
            /// </summary>
            private List<Observe> _observes = new List<Observe>();

            /// <summary>
            /// 添加关注对象
            /// </summary>
            /// <param name="observe"></param>
            public void Attach(Observe observe)
            {
                _observes.Add(observe);
            }

            /// <summary>
            /// 移除关注对象
            /// </summary>
            /// <param name="observe"></param>
            public void Detach(Observe observe)
            {
                _observes.Remove(observe);
            }

            /// <summary>
            /// 通知所有目标做出响应
            /// </summary>
            public void NotifyAllObserves()
            {
                for (int i =_observes.Count-1; i >-1 ; i--)
                {
                    _observes[i].Update();
                }
            }
        }

        /// <summary>
        /// 关注的对象：观察者
        /// </summary>
        public abstract class Observe
        {
            /// <summary>
            /// 对目标的通知做出响应
            /// </summary>
            public abstract void Update();
        }

        /// <summary>
        /// 罪犯
        /// </summary>
        public class Criminal:Subject
        {
            /// <summary>
            /// 当前位置
            /// </summary>
            private string _location;

            /// <summary>
            /// 当前位置属性
            /// </summary>
            public string Location { get => _location; }

            /// <summary>
            /// 罪犯逃跑到何处
            /// </summary>
            /// <param name="location"></param>
            public void RunAway(string location)
            {
                _location = location;
                Console.WriteLine($"罪犯跑向：{location}");
                base.NotifyAllObserves();
            }

        }

        /// <summary>
        /// 警察
        /// </summary>
        public class Police : Observe
        {
            /// <summary>
            /// 关注的对象
            /// </summary>
            private Subject _subject = null;

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="subject"></param>
            public Police(Subject subject)
            {
                _subject = subject;
                _subject.Attach(this);
            }

            /// <summary>
            /// 关注对象行为改变时，触发相关动作
            /// </summary>
            public override void Update()
            {
                Console.WriteLine($"警方在：{(_subject as Criminal).Location}部署警力围堵罪犯！"); ;
            }
        }

        /// <summary>
        /// 市民
        /// </summary>
        public class Citizen : Observe
        {
            /// <summary>
            /// 关注的对象
            /// </summary>
            private Subject _subject = null;

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="subject"></param>
            public Citizen(Subject subject)
            {
                _subject = subject;
                _subject.Attach(this);
            }

            /// <summary>
            /// 关注对象行为改变时，触发相关动作
            /// </summary>
            public override void Update()
            {
                Console.WriteLine($"市民拨打110，告知警方罪犯在：{(_subject as Criminal).Location}"); ;
            }
        }
```

### 20.备忘录模式

- 在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可以将该对象恢复到原先保存的状态。
- Memento模式保存了封装的边界，一个Memento对象是另一种原发器对象的表示，不会被其他代码改动。这种模式简化了原发器对象，Memento只保存原发器的状态。采用堆栈备忘对象，可以实现多次取消操作。

```
        static void Main(string[] args)
        {
            Player player = new Player();
            CrackMemo crackMemo = new CrackMemo();
            crackMemo.DictMemento.Add(1, player.Save());
            player.Attack(1);

            player.Attack(2);
            crackMemo.DictMemento.Add(2, player.Save());
            player.Attack(3);
            crackMemo.DictMemento.Add(3, player.Save());
            player.Load(crackMemo.DictMemento[1]);
            Console.WriteLine(player);
        }

        /// <summary>
        /// 玩者
        /// </summary>
        public class Player:IOriginator
        {

            /// <summary>
            /// 生命值
            /// </summary>
            private int _life=200;
            public int Life { get { return _life; } }

            /// <summary>
            /// 加载进度
            /// </summary>
            /// <param name="memento"></param>
            public void Load(Memento memento)
            {
                _life=memento.Life;
            }

            /// <summary>
            /// 保存进度
            /// </summary>
            /// <param name="key"></param>
            public Memento Save()
            {
                return new Memento() { Life=_life};
            }

            public override string ToString()
            {
                return $"当前玩家生命值：{_life},游戏是否结束：{_life<1}";
            }

            /// <summary>
            /// 攻击
            /// </summary>
            /// <param name="index"></param>
            public void Attack(int index)
            {
                if (_life>0)
                {
                    Console.WriteLine($"第{index}次攻击！");
                    _life -= new Random().Next(150);
                    Console.WriteLine(this);
                }
                else
                {
                    Console.WriteLine($"玩家生命值已为0！");
                }
            }
        }

        /// <summary>
        /// 加载和保存备忘
        /// </summary>
        public interface IOriginator
        {
            /// <summary>
            /// 加载备忘
            /// </summary>
            /// <param name="memento"></param>
            void Load(Memento memento);

            /// <summary>
            /// 保存备忘
            /// </summary>
            /// <returns></returns>
            Memento Save();
        }

        /// <summary>
        /// 存档管理
        /// </summary>
        public class CrackMemo
        {
            /// <summary>
            /// 存档对象
            /// </summary>
            public Dictionary<int, Memento> DictMemento = new Dictionary<int, Memento>();


            /// <summary>
            /// 加载档案
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public Memento LoadMemo(int index)
            {
                return DictMemento[index];
            }

            /// <summary>
            /// 存档
            /// </summary>
            /// <param name="index"></param>
            /// <param name="memento"></param>
            public void SaveMemo(int index,Memento memento)
            {
                DictMemento.Add(index, memento);
            }
        }
        /// <summary>
        /// 封装数据
        /// </summary>
        public class Memento
        {
            /// <summary>
            /// 记录单前的生命值
            /// </summary>
            public int Life { get; set; }
        }
```

### 21.状态模式

- 允许一个对象在其内部状态改变时改变它的行为。从而使对象看起来似乎修改了其行为。
- 核心思想就是：当对象的状态改变时，同时改变其行为，很好理解！就拿QQ来说，有几种状态，在线、隐身、忙碌等，每个状态对应不同的操作，而且你的好友也能看到你的状态，所以，状态模式就两点：1、可以通过改变状态来获得不同的行为。2、你的好友能同时看到你的变化。

```
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.CurrentHealthState = new Strong();
            teacher.Teach();

            teacher.CurrentHealthState = new Sick();
            teacher.Teach();

            Console.WriteLine("");
        }

        /// <summary>
        /// 身体健康状态
        /// </summary>
        public abstract class HealthState
        {
            public abstract void Work();
        }

        /// <summary>
        /// 健康状态
        /// </summary>
        public class Strong : HealthState
        {
            public override void Work()
            {
                Console.WriteLine("体力充沛干活贼顺！"); ;
            }
        }

        /// <summary>
        /// 生病状态
        /// </summary>
        public class Sick : HealthState
        {
            public override void Work()
            {
                Console.WriteLine("体弱多病，诸事不顺！"); ;
            }
        }


        /// <summary>
        /// 工人
        /// </summary>
        public class Teacher
        {
            /// <summary>
            /// 暴露当前状态
            /// </summary>
            public HealthState CurrentHealthState { get; set; }

            /// <summary>
            /// 干活
            /// </summary>
            /// <param name="healthState"></param>
            public void Teach()
            {
                CurrentHealthState.Work();
            }
        
        }
```

### 22.策略模式

- 定义一系列算法，把它们一个个封装起来，并且使它们可以相互替换。该模式使得算法可以独立于使用它的客户而变化。

```
        static void Main(string[] args)
        {
            Customer customer = new Customer(1000);
            customer.AddStrategy(new GiveAway());
            customer.AddStrategy(new Discount());
            customer.AddStrategy(new Deduction());

            customer.Promoto();

            Console.WriteLine("");
        }

        /// <summary>
        /// 优惠策略
        /// </summary>
        public abstract class Strategy
        {
            /// <summary>
            /// 计算优惠价格
            /// </summary>
            /// <param name="currentPrice"></param>
            public abstract void Algorith(ref double currentPrice);
        }

        /// <summary>
        /// 赠送
        /// </summary>
        public class GiveAway : Strategy
        {
            public override void Algorith(ref double currentPrice)
            {
                Console.WriteLine("赠送一个玩具！"); ;
            }
        }

        /// <summary>
        /// 打折
        /// </summary>
        public class Discount : Strategy
        {
            public override void Algorith(ref double currentPrice)
            {
                currentPrice *= 0.8;
                Console.WriteLine("打八折！"); ;
            }
        }
        /// <summary>
        /// 抵扣
        /// </summary>
        public class Deduction : Strategy
        {
            public override void Algorith(ref double currentPrice)
            {
                if (currentPrice>500)
                {
                    currentPrice -= 50;
                    Console.WriteLine("总价减50"); ;
                }
                else
                {
                    Console.WriteLine("总价未达到抵扣最低标准！"); ;
                }
            }
        }

        /// <summary>
        /// 顾客
        /// </summary>
        public class Customer
        {
            /// <summary>
            /// 商品价格
            /// </summary>
            private double _price;

            /// <summary>
            /// 折扣策略
            /// </summary>
            private List<Strategy> strategies = new List<Strategy>();

            /// <summary>
            /// 构造函数
            /// </summary>
            /// <param name="price"></param>
            public Customer(double price)
            {
                _price = price;
            }
            /// <summary>
            /// 增加策略
            /// </summary>
            /// <param name="strategy"></param>
            public void AddStrategy(Strategy strategy)
            {
                strategies.Add(strategy);
            }

            /// <summary>
            /// 计算折扣
            /// </summary>
            public void Promoto()
            {
                foreach (var item in strategies)
                {
                    item.Algorith(ref _price);
                    Console.WriteLine(this);
                }
            }

            public override string ToString()
            {
                return $"当前商品价格：{_price}";
            }
        }
 
```

### 23.访问者模式

- 表示在一个作用于某对象结构中的各元素的操作。它可以在不改变各元素的类的前提下定义作用于这些元素的新的操作。

```
        static void Main(string[] args)
        {
            EXPO expo = new EXPO();
            expo.AddMuseum(new ChinaMuseum());
            expo.AddMuseum(new EnglandMuseum());

            Visitor civilizedvisitor = new CivilizedVisitor();
            Visitor uncivilizedvisitor = new UnCivilizedVisitor();

            expo.Welcome(civilizedvisitor);

            expo.Welcome(uncivilizedvisitor);
            Console.WriteLine("");
        }

        /// <summary>
        /// 游客
        /// </summary>
        public abstract class Visitor
        {
            /// <summary>
            /// 访问中国馆
            /// </summary>
            /// <param name="chinaMuseum"></param>
            public abstract void VisitChinaMuseum(ChinaMuseum chinaMuseum);

            /// <summary>
            /// 访问英国馆
            /// </summary>
            /// <param name="englandMuseum"></param>
            public abstract void VisitEnglandMuseum(EnglandMuseum englandMuseum);
        }

        /// <summary>
        /// 文明游客
        /// </summary>
        public class CivilizedVisitor : Visitor
        {
            public override void VisitChinaMuseum(ChinaMuseum chinaMuseum)
            {
                Console.WriteLine("看完舞蹈，鼓掌！"); ;
            }

            public override void VisitEnglandMuseum(EnglandMuseum englandMuseum)
            {
                Console.WriteLine("看完演奏，鼓掌！"); ;
            }
        }

        /// <summary>
        /// 不文明游客
        /// </summary>
        public class UnCivilizedVisitor : Visitor
        {
            public override void VisitChinaMuseum(ChinaMuseum chinaMuseum)
            {
                Console.WriteLine("在馆内喧哗"); ;
            }

            public override void VisitEnglandMuseum(EnglandMuseum englandMuseum)
            {
                Console.WriteLine("在馆内打电话"); ;
            }
        }


        /// <summary>
        /// 场馆
        /// </summary>
        public abstract class Museum
        {
            /// <summary>
            /// 接待游客
            /// </summary>
            /// <param name="visitor"></param>
            public abstract void Accept(Visitor visitor);
        }

        /// <summary>
        /// 中国馆
        /// </summary>
        public class ChinaMuseum : Museum
        {
            public override void Accept(Visitor visitor)
            {
                Dance();
                visitor.VisitChinaMuseum(this);
            }

            /// <summary>
            /// 舞蹈
            /// </summary>
            private void Dance()
            {
                Console.WriteLine("56个名族，56朵花");
            }
        }

        /// <summary>
        /// 英国馆
        /// </summary>
        public class EnglandMuseum : Museum
        {
            public override void Accept(Visitor visitor)
            {
                Play();
                visitor.VisitEnglandMuseum(this);
            }

            /// <summary>
            /// 舞蹈
            /// </summary>
            private void Play()
            {
                Console.WriteLine("演奏风笛");
            }
        }

        /// <summary>
        /// 世博会
        /// </summary>
        public class EXPO
        {
            private List<Museum> museums = new List<Museum>();

            /// <summary>
            /// 增加分馆
            /// </summary>
            /// <param name="museum"></param>
            public void AddMuseum(Museum museum )
            {
                museums.Add(museum);
            }

            /// <summary>
            /// 欢迎游客
            /// </summary>
            /// <param name="visitor"></param>
            public void Welcome(Visitor visitor)
            {
                foreach (var item in museums)
                {
                    item.Accept(visitor);
                }
            }
        }
```


# 总结 #

- 外观模式注重简化接口
- 适配器模式注重转换接口
- 桥接模式注重分离接口（抽象）与实现
- 装饰模式注重稳定接口的前提下为对象扩展功能

简单工厂

- 只有一个工厂（具体的，没有抽象）
- 只生产一种产品（抽象的产品）
- 这种产品可以有多重具体产品类型（派生）

 ```
    public class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("请输入第一数：");
            int numberA = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二数：");
            int numberB = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            string operation = Console.ReadLine();

            Calculation calculation = SimpleFactory.LoadCalculation(operation);
            calculation.NumberA = numberA;
            calculation.NumberB = numberB;
            Console.WriteLine($"{numberA} {operation} {numberB} = {calculation.GetResult()}");
        }
    }

    /// <summary>
    /// 由工厂类创建需要的计算类型对象，调用者不需要知道其内部创建过程
    /// </summary>
    public static class SimpleFactory
    {
        public static Calculation LoadCalculation(string operation)
        {
            Calculation calculation = null;
            switch (operation)
            {
                case "+":
                    calculation = new AddCalculation();
                    break;
                case "-":
                    calculation = new SubCalculation();
                    break;
                case "*":
                    calculation = new MulCalculation();
                    break;
                case "/":
                    calculation = new DivCalculation();
                    break;
                default:
                    break;
            }
            return calculation;
        }
    }

    public abstract class Calculation
    {
        protected int _numberA;
        public int NumberA { get => _numberA; set => _numberA = value; }

        protected int _numberB;
        public int NumberB { get => _numberA; set => _numberA = value; }

        public abstract int GetResult();

    }

    public class AddCalculation : Calculation
    {
        public override int GetResult()
        {
            return base._numberA + base._numberB;
        }
    }

    public class SubCalculation : Calculation
    {
        public override int GetResult()
        {
            return base._numberA - base._numberB;
        }
    }

    public class MulCalculation : Calculation
    {
        public override int GetResult()
        {
            return base._numberA * base._numberB;
        }
    }

    public class DivCalculation : Calculation
    {
        public override int GetResult()
        {
            if (base._numberB==0)
            {
                throw new Exception("被除数不能为0");
            }
            return base._numberA / base._numberB;
        }
    }

 ```

